using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practicum_Klassen
{
    class HardDisk
    {
        private int size;
        private string model;

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                if (value < 0)
                {
                    size = 0;
                }
                else
                {
                    size = value;
                }
            }
        }

        public string Model
        {
            get
            {
                if (model == string.Empty)
                {
                    return "Model niet gekend";
                }
                return model;
            }

            set
            {
                model = value;
            }
        }
    }
}
