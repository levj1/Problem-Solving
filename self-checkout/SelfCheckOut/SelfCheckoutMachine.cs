using System;

namespace SelfCheckOut
{
    public class SelfCheckoutMachine
    {
        private int priceInCent;
        private int SalsaQuantity;
        private int ChipQuantity;
        private int CigaretteQuantity;
        private bool HasBonusCard;        

        public void Scan(int sku)
        {
            if(sku == 9999)
            {
                HasBonusCard = true;
            }
            else
            {
                priceInCent += CovertSKUToCents(sku);
            }
            
        }

        public int GetTotal()
        {
            var discount = 0;
            if (HasBonusCard)
            {
                discount = ApplyDiscount();
            }

            if (CigaretteQuantity > 0)
            {
                var cigaretteSurcharge = (CigaretteQuantity * 50);
                return priceInCent - discount + cigaretteSurcharge;
            }

            return priceInCent - discount;
        }

        private void SendScannedItemApiCall() { }
        private int ApplyDiscount()
        {
            // Discount for salsa is total item price divided by 2
            var salsaDiscount = (SalsaQuantity * 100) / 2;

            var chipDiscount = (ChipQuantity / 3) * 200;

            var discount = salsaDiscount + chipDiscount;            

            return discount;
        }

        // Refactor
        int CovertSKUToCents(int sku)
        {
            int price = 0;
            switch (sku)
            {
                case 123:
                    price = 200;
                    ChipQuantity++;
                    Log("Item 123 scanned.");
                    break;

                case 456:
                    price = 100;
                    SalsaQuantity++;
                    Log("Item 456 scanned.");
                    break;

                case 789:
                    price = 1000;
                    Log("Item 789 scanned.");
                    break;

                case 111:
                    price = 500;
                    CigaretteQuantity++;
                    Log("Item 111 scanned.");
                    break;
            }

            return price;
        }

        private void Log(string message)
        {
            
        }
    }
}
