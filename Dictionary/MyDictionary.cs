using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<_TKey, _TValue>
    {
        _TKey[] keys;
        _TValue[] values;
        public MyDictionary()
        {
            keys = new _TKey[0];
            values = new _TValue[0]; 
        }
        public void Add(_TKey, _TValue)
        {
            _TKey[] tempKeys = keys;
            _TValue[] tempValues = values;
            keys = new _TKey[keys.Length + 1];
            values = new _TValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                for (int j = 0; j < tempValues.Length; j++)
                {
                    values[j] = tempValues[j];
                }
            }
            _TKey = keys.Length - 1;
        }
    }
}
