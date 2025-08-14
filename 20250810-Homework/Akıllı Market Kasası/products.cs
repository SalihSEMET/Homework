using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akıllı_Market_Kasası
{
    public class products
    {
        string[] _products = new string[10]
        { "kola", "sabun", "çikolata", "kalem", "ekmek", "mısır", "soda", "peynir", "sakız", "dondurma" };
        int[] _cost = new int[10]
            {50,30,60,20,15,25,10,150,5,70};
        int[] _barcodenumber = new int[10] { 1, 3, 5, 2, 4, 6, 7, 9, 8, 10};
        #region Methots
        public void Showproductsandcost()
        {
            for (int i = 0; i < _products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. Ürün:{_products[i]} Fiyatı:{_cost[i]} Barkod Numarası:{_barcodenumber[i]}");
            }
        }

        public int[] GetBarcodes()
        {
            return _barcodenumber;
        }
        public int[] GetCost()
        {
            return _cost;
        }
        public Dictionary<int, int> GetBarcodePriceMap()
        {
            Dictionary<int, int> BarcodePriceMap = new Dictionary<int, int>();
            for (int i = 0; i < _barcodenumber.Length; i++)
            {
                BarcodePriceMap[_barcodenumber[i]] = _cost[i];
            }
            return BarcodePriceMap;
        }
        #endregion




    }

}
