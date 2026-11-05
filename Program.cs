using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khantikun");
            Console.WriteLine("Week 2");
            Console.WriteLine("-----------------------");




            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)
            };


            Console.WriteLine("รายชื่อร้านอาหารทั้งหมด");
            foreach (var item in restaurants)
            {
                Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
            }
        }
    }


    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Score { get; set; }


        public Restaurant(int id, string name, string type, double score)
        {
            Id = id;
            Name = name;
            Type = type;
            Score = score;
        }
    }

    // ===== D | branch: feature/search-restaurant =====
// งาน: ค้นหาร้านจากชื่อ (พิมพ์บางส่วนก็ได้) แล้วแสดงผล ถ้าไม่พบให้แจ้งผู้ใช้
// วิธีใช้: วางแทนเมธอดว่าง SearchRestaurant ใน Program.cs


// ---------- commit ที่ 1 : ให้ทำงานได้ตามโจทย์ (ขั้นที่ 6) ----------
static void SearchRestaurant(List<Restaurant> restaurants)
        {
            Console.Write("พิมพ์ชื่อร้านที่ต้องการค้นหา: ");
            string keyword = Console.ReadLine();


            bool found = false;
            foreach (var item in restaurants)
            {
                if (item.Name.Contains(keyword))
                {
                    Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
                    found = true;
                }
            }


            if (!found)
            {
                Console.WriteLine("ไม่พบร้านที่ค้นหา");
            }
        }
    }

    // ---------- commit ที่ 2 : ปรับปรุง เพิ่มหัวข้อ + ไม่สนตัวพิมพ์เล็ก/ใหญ่ + บอกคำที่ค้นหา (ขั้นที่ 7) ----------
static void SearchRestaurant(List<Restaurant> restaurants)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("ค้นหาร้านอาหาร");


    Console.Write("พิมพ์ชื่อร้าน (บางส่วนก็ได้): ");
    string keyword = Console.ReadLine();


    bool found = false;
    foreach (var item in restaurants)
    {
        if (item.Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
        {
            Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
            found = true;
        }
    }


    if (!found)
    {
        Console.WriteLine($"ไม่พบร้านที่ชื่อมีคำว่า \"{keyword}\"");
    }
}
}