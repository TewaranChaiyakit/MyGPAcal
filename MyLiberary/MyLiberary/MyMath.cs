using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLiberary
{
    public class MyMath //จะให้ใช้Class ได้ อย่าลืม เปลี่ยนจาก internal เป็น public
    {
        public int getSummatiom(int a, int b)
        {
            //สร้างฟังก์ชั่นMedtod getSummation จะตามด้วย() ขึ้นมา นำด้วย int type ข้อมูลเพราะเป็นเลข double ทศนิยม
            //()อบู่ตอนเราสร้าง medtod เรียกว่า paramiter แต่่ถ้า ()อยู่ในวิธ๊ทำ จะเรียกว่า agreement
            return a + b;

        }
        public int getSummation(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
