using System;

namespace DemoWpfMvvm.Models
{
    internal class Data
    {
        public DateTime DateTime { get; private set; }

        public Data()
        {
            Update();
        }

        public void Update()
        {
            DateTime = DateTime.Now;
        }
    }
}