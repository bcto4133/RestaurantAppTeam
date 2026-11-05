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
        // ===== B | branch: feature/good-rating =====
        // งาน: แสดงเฉพาะร้านที่คะแนนตั้งแต่ 4.5 ขึ้นไป
        // วิธีใช้: วางแทนเมธอดว่าง ShowGoodRating ใน Program.cs


        // ---------- commit ที่ 1 : ให้ทำงานได้ตามโจทย์ (ขั้นที่ 6) ----------
        static void ShowGoodRating(List<Restaurant> restaurants)
        {
            foreach (var item in restaurants)
            {
                if (item.Score >= 4.5)
                {
                    Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
                }
            }
        }
        // ---------- commit ที่ 2 : ปรับปรุง เพิ่มหัวข้อ + แจ้งเมื่อไม่มีร้านที่เข้าเงื่อนไข (ขั้นที่ 7) ----------
        static void ShowGoodRating(List<Restaurant> restaurants)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("ร้านอาหารที่คะแนน 4.5 ขึ้นไป");


            bool found = false;
            foreach (var item in restaurants)
            {
                if (item.Score >= 4.5)
                {
                    Console.WriteLine($"ID: {item.Id} | ร้าน: {item.Name} | ประเภท: {item.Type} | คะแนน: {item.Score}");
                    found = true;
                }
            }


            if (!found)
            {
                Console.WriteLine("ไม่มีร้านที่คะแนนตั้งแต่ 4.5 ขึ้นไป");
            }
        }
    }
}