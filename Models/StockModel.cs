using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace StockManager.Models
{
    public class StockModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public decimal Change { get; set; }

        public Brush? ChangeTextBrush { get; set; } // 변동 텍스트의 색상

        public StockModel()
        {
            Name = "";
            Code = "";
        }
    }
}
