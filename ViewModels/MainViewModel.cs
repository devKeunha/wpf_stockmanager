using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;
using StockManager.Models;

namespace StockManager.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<StockModel> Stocks { get; set; }

        public MainViewModel()
        {
            // 가상의 주식 정보 생성
            List<StockModel> stockList = new List<StockModel>
            {
                new StockModel { Name = "삼성전자", Code = "005930", Price = 75000, Change = 2500, ChangeTextBrush = Brushes.Black},
                new StockModel { Name = "LG화학", Code = "051910", Price = 650000, Change = -5000, ChangeTextBrush = Brushes.Black },
                new StockModel { Name = "현대차", Code = "005380", Price = 230000, Change = 8000, ChangeTextBrush = Brushes.Black },
                // 여기에 더 많은 주식 정보를 추가할 수 있습니다.
            };

            // Stocks 컬렉션에 주식 정보 추가
            Stocks = new ObservableCollection<StockModel>(stockList);

            // 금액의 상승 또는 하락 여부에 따라 텍스트 색상 변경
            foreach (StockModel stock in Stocks)
            {
                if (stock.Change > 0)
                {
                    stock.ChangeTextBrush = Brushes.Red; // 금액 상승 시 초록색
                }
                else if (stock.Change < 0)
                {
                    stock.ChangeTextBrush = Brushes.Blue; // 금액 하락 시 빨간색
                }
                else
                {
                    stock.ChangeTextBrush = Brushes.Black; // 변동 없을 때 검정색
                }
            }
        }
    }

}
