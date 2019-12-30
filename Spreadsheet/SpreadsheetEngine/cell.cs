using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SpreadsheetEngine
{
    class cell : INotifyPropertyChanged 
    {
        private int rowIndex;
        private int columnIndex;
        protected string Text;


        public int getRow
        {
            get { return rowIndex; }
        }

        public int getColumn
        {
            get { return columnIndex;}
        }



    }
}
