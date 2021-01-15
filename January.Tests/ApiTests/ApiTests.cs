using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace January.Tests.ApiTests
{
    internal class XyzWebApiTests
    {
        private XyzWebApi _sut;
        private Mock<HttpMessageHandler> _handlerMock;

        [SetUp]
        public void Setup()
        {
            _handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            var httpClient = new HttpClient(_handlerMock.Object);
            _sut = new XyzWebApi(httpClient);
        }

        [Test]
        public async Task ShouldReturnNotFoundMessageWhenCallHealthCheckEndpoint()
        {
            _handlerMock
                   .Protected()
                   .Setup<Task<HttpResponseMessage>>(
                       "SendAsync",
                       ItExpr.IsAny<HttpRequestMessage>(),
                       ItExpr.IsAny<CancellationToken>()
                   )
                   .ReturnsAsync(new HttpResponseMessage()
                   {
                       StatusCode = HttpStatusCode.NotFound
                   })
                   .Verifiable();

            var actual = await _sut.HealthCheck();

            Assert.AreEqual(actual, HttpStatusCode.NotFound);

            var expectedUri = new Uri("http://xyz-web-api.com/health");
            _handlerMock.Protected().Verify(
                "SendAsync",
                Times.Exactly(1),
                ItExpr.Is<HttpRequestMessage>(req =>
                        req.Method == HttpMethod.Get
                        && req.RequestUri == expectedUri
                ),
                ItExpr.IsAny<CancellationToken>()
            );
        }
    }

    internal class XyzWebApi
    {
        private const string BaseAddress = "http://xyz-web-api.com";
        private readonly HttpClient _client;

        public XyzWebApi(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpStatusCode> HealthCheck()
        {
            var response = await _client.GetAsync($"{BaseAddress}/health");
            return response.StatusCode;
        }
    }
}
