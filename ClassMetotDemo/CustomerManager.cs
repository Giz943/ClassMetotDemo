using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager 
    {
        public void Get(Customer customer) //Get: Müşterilerin bilgirini yazdırır.  // "/n" : Alt satıra geçiş anlamındadır.Enter gibi düşün.
        {
            Console.WriteLine("\n" + "CustomerID: " + customer.CustomerID + " | CustomerName: " + customer.CustomerName + " | CustomerLastName: " + customer.CustomerLastName);
        }

        public List<Customer> GetAll(List<Customer> customerList) //Public: Dışardan erişmek.
        {
            foreach (var customer in customerList) // customerlist deki tüm müşterilere customer ismi ile hitap ediyoruz.
            {
                Console.WriteLine("CustomerID: " + customer.CustomerID + " | CustomerName: " + customer.CustomerName + " | CustomerLastName: " + customer.CustomerLastName + "\n");
            }

            return customerList; // Return:Listedekileri yazdır ve tekrar dön.
        }

        public List<Customer> Add(Customer customer, List<Customer> customerList) // Müşteri alıcam, bu müşteriyi hangi listeye eklediğimi belirtmek için kullundığım kod.
        {
            customerList.Add(customer); //Bu kod ile o listeye bir eleman eklemiş olurum.
            Console.WriteLine(customer.CustomerID + " " + customer.CustomerName + " " + customer.CustomerLastName + " | Added! \n"); 
            GetAll(customerList);// Yeni eklenen müşteri dahişlinde o listeyi ekrana yazdırırım. 
            return customerList; // Yeni halini elimde bulunsun diye iletilir.
        }

        public void Delete(Customer customer, List<Customer> customerList)
        {
            customerList.Remove(customer);
            GetAll(customerList);
            Console.WriteLine("Deleted!");
        }
                                            //neyi güncelliycem.  //var olan değeri kullanma. //yenideğeri.          //güncellecenecek liste.
        public List<Customer> Update(string updatedInfo, object availableValue, object changedValue, List<Customer> customerList) //object: herhangi bir tür.
        {
            if (updatedInfo == "CustomerID") //Neyi güncellemek istediğim.
            {
                foreach (var item in customerList) //Bir döngü oluştururuz, listedeki tüm elemanları teker teker kontrol eder.
                {
                    if (item.CustomerID == Convert.ToInt32(availableValue)) // Convert.ToInt32 : içerisine yazılan değerin sayısal karşılığını verir.
                    {
                        item.CustomerID = Convert.ToInt32(changedValue);// Eski değeri yeni dğer ile değiştirdim.

                    }
                }
            }

            if (updatedInfo == "CustomerName") //İf: Eğer koşulu sağlıyor ise uygular.Bu 3 değerden biri çalışabilir.Hepsi aynı anda çalışamaz.
            {
                foreach (var item in customerList)
                {
                    if (item.CustomerName == availableValue.ToString())
                    {
                        item.CustomerName = changedValue.ToString();
                    }
                }
            }

            if (updatedInfo == "CustomerLastName")
            {
                foreach (var item in customerList)
                {
                    if (item.CustomerLastName == availableValue.ToString())
                    {
                        item.CustomerLastName = changedValue.ToString();
                    }
                }
            }


            Console.WriteLine("Updated!\n");
            GetAll(customerList);
            return customerList;
        }

    }
}
