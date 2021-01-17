using System;

namespace Shared.Models
{
    public class MinHeap
    {
        private int _capacity = 10;
        private int _size;

        private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

        private bool hasLeftChild(int parentIndex) => GetLeftChildIndex(parentIndex) < _size;
        private bool hasRightChild(int parentIndex) => GetRightChildIndex(parentIndex) < _size;
        private bool hasParent(int childIndex) => GetParentIndex(childIndex) >= 0;

        private int[] _items;

        public int Size => _size;

        public MinHeap()
        {
            _items = new int[_capacity];
        }

        public int Peek()
        {
            if(_size == 0) throw new IndexOutOfRangeException();
            return _items[0];
        }

        public int Poll()
        {
            if (_size == 0) throw new IndexOutOfRangeException();

            var item = _items[0];
            _items[0] = _items[_size - 1];
            _size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureArrayHasExtraSpace();
            _items[_size] = item;
            _size++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            var childIndex = _size - 1;
            var parentIndex = GetParentIndex(childIndex);

            while (hasParent(childIndex) && _items[parentIndex] > _items[childIndex])
            {
                Swap(parentIndex, childIndex);
                childIndex = parentIndex;
                parentIndex = GetParentIndex(childIndex);
            }
        }

        private void HeapifyDown()
        {
            var startIndex = 0;

            while (hasLeftChild(startIndex))
            {
                var smallerChildIndex = GetLeftChildIndex(startIndex);
                if (hasRightChild(startIndex) && _items[GetRightChildIndex(startIndex)] < _items[smallerChildIndex])
                {
                    smallerChildIndex = GetRightChildIndex(startIndex);
                }

                if(_items[startIndex] < _items[smallerChildIndex]) break;
                
                Swap(startIndex, smallerChildIndex);
                startIndex = smallerChildIndex;
            }
        }

        private void EnsureArrayHasExtraSpace()
        {
            if (_size != _capacity) return;

            _capacity *= 2;
            Array.Resize(ref _items, _capacity);
        }

        private void Swap(int index1, int index2)
        {
            var temp = _items[index2];
            _items[index2] = _items[index1];
            _items[index1] = temp;
        }
    }
}