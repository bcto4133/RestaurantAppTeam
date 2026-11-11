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

<<<<<<< HEAD
    

    // ===== A | branch: feature/add-restaurant =====
// งาน: รับชื่อร้าน ประเภท และคะแนนจากคีย์บอร์ด แล้วเพิ่มเข้า List
// วิธีใช้: วางแทนเมธอดว่าง AddRestaurant ใน Program.cs (ไม่ต้องแก้ class Restaurant)
 
// ---------- commit ที่ 1 : ให้ทำงานได้ตามโจทย์ (ขั้นที่ 6) ----------
static void AddRestaurant(List<Restaurant> restaurants)
        {
            Console.Write("ชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("ประเภท: ");
            string type = Console.ReadLine();

            Console.Write("คะแนน: ");
            double score = double.Parse(Console.ReadLine());

            int newId = restaurants.Count + 1;
            restaurants.Add(new Restaurant(newId, name, type, score));

            ShowRestaurants(restaurants);
        }
    }

    // ---------- commit ที่ 2 : ปรับปรุง เพิ่มหัวข้อ + ตรวจคะแนน 0-5 (ขั้นที่ 7) ----------
static void AddRestaurant(List<Restaurant> restaurants)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("เพิ่มร้านอาหารใหม่");

    Console.Write("ชื่อร้าน: ");
    string name = Console.ReadLine();

    Console.Write("ประเภท: ");
    string type = Console.ReadLine();

    Console.Write("คะแนน (0-5): ");
    double score;
    while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 5)
    {
        Console.Write("กรอกคะแนนไม่ถูกต้อง ลองใหม่ (0-5): ");
    }

    int newId = restaurants.Count + 1;
    restaurants.Add(new Restaurant(newId, name, type, score));
    Console.WriteLine($"เพิ่มร้าน {name} เรียบร้อย");

    Console.WriteLine("-----------------------");
    ShowRestaurants(restaurants);
}

// ===== C | branch: feature/summary =====
// งาน: แสดงร้านที่คะแนนสูงสุด และร้านที่คะแนนต่ำสุด
// วิธีใช้: วางแทนเมธอดว่าง ShowSummary ใน Program.cs


// ---------- commit ที่ 1 : ให้ทำงานได้ตามโจทย์ (ขั้นที่ 6) ----------
static void ShowSummary(List<Restaurant> restaurants)
{
    Restaurant best = restaurants[0];
    Restaurant worst = restaurants[0];


    foreach (var item in restaurants)
    {
        if (item.Score > best.Score) best = item;
        if (item.Score < worst.Score) worst = item;
    }


    Console.WriteLine($"คะแนนสูงสุด: {best.Name} ({best.Score})");
    Console.WriteLine($"คะแนนต่ำสุด: {worst.Name} ({worst.Score})");
}

// ---------- commit ที่ 2 : ปรับปรุง เพิ่มหัวข้อ + กันกรณี List ว่าง (ขั้นที่ 7) ----------
static void ShowSummary(List<Restaurant> restaurants)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("สรุปคะแนนร้านอาหาร");


    if (restaurants.Count == 0)
    {
        Console.WriteLine("ยังไม่มีข้อมูลร้านอาหาร");
        return;
    }


    Restaurant best = restaurants[0];
    Restaurant worst = restaurants[0];


    foreach (var item in restaurants)
    {
        if (item.Score > best.Score) best = item;
        if (item.Score < worst.Score) worst = item;
    }


    Console.WriteLine($"คะแนนสูงสุด: {best.Name} | {best.Type} | {best.Score}");
    Console.WriteLine($"คะแนนต่ำสุด: {worst.Name} | {worst.Type} | {worst.Score}");
}


=======
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
>>>>>>> feature/searchrestaurant
}