using System;   // เรียกใช้ Namespace

namespace basicProgramming  // Namespace
{
    class Program  // ชื่อคลาส
    {
        static void Main(string[] args)
        {

            /*
            // การกำหนดลำดับการแสดงผลด้วยปีกกา
            Console.WriteLine("Hello = {0}, Name = {1}, Age = {2}","Mod","Jirawut", 28 );
            Console.WriteLine("{0} + {1} = {2}", 8, 5, 13);
            Console.ReadLine();  // อ่านค้างไว้
            */

            //---------------------------------------------------------------------------------

            /*
            // การนิยามตัวแปร int (จำนวนเต็ม)
            int x = 10;
            int y = 20;

            // การนิยามตัวแปร float (เลขทศนิยม 16 bit)
            float a = 10.12f;
            float b = 20f;

            // การนิยามตัวแปร double (เลขทศนิยม 32 bit)
            double number1 = 500;
            double number2 = 1200;

            // การนิยามตัวแปร boolean (true, false)
            bool status1 = false;
            bool status2 = true;

            // การนิยามตัวแปร char & string
            char a1 = 'A';
            string name = "Jirawut";

            // การกำหนดตัวแปรก่อน กำหนดค่าทีหลัง
            int z;
            float c;
            double number3;
            bool status3;

            z = 16;
            c = 12.45f;
            number3 = 45.78f;
            status3 = true;

            Console.WriteLine(z);
            Console.WriteLine(c);
            Console.WriteLine(number3);
            Console.WriteLine(status3);
            Console.WriteLine(name);
            Console.Read();
            */

            //---------------------------------------------------------------------------------

            /*
            // ค่าคงที่ (Constant)
            const int MOD = 123;
            const bool PO = true;

            Console.WriteLine(MOD);
            Console.WriteLine(PO);
            Console.Read();
            */

            //---------------------------------------------------------------------------------

            /*
            // Format String
            int number = 1234567;
            Console.WriteLine("Number = {0}", number);
            Console.WriteLine("Number = {0:E}", number); // Exponential (รูปแบบตัวเลขชี้กำลัง)
            Console.WriteLine("Number = {0:F}", number); // Floating Point (เลขทศนิยม)
            Console.WriteLine("Number = {0:G}", number); // แสดงตัวเลขรูปแบบสั้นที่สุด
            Console.WriteLine("Number = {0:N}", number); // Number ใส่ comma คั่นทุกๆ 3 หลัก
            Console.WriteLine("Number = {0:P}", number); // Percentage (เลขเป็น %)
            Console.WriteLine("Number = {0:X}", number); // Hexadecimal (เลขฐาน 16)
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // รับค่าผ่านคีย์บอร์ด
            Console.Write("Input = "); // ข้อความ
            string result = Console.ReadLine();  // result รับค่าจากคีย์บอร์ด
            Console.WriteLine(result);   // แสดงค่าของ result 
            Console.ReadKey(); 
            */

            //---------------------------------------------------------------------------------

            /*
            // ฟังก์ชั่นทางคณิตศาสตร์
            float numBer = 14.23f;
            double numBer2 = 34.56;
            const double numBer3 = 3.14;
            Console.WriteLine("Abs = {0}", Math.Abs(numBer)); // ค่าสมบูรณ์ของ x (|x|)
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(numBer)); // ปัดเศษทศนิยมขึ้นทุกกรณี
            Console.WriteLine("Floor = {0}", Math.Floor(numBer)); // ปัดเศษทศนิยมทิ้งทุกกรณี
            Console.WriteLine("Round = {0}", Math.Round(numBer)); // ปัดเศษทศนิยม >= .5 เป้นต้นไปปัดเศษขึ้น ถ้า < .5 ให้ปัดเศษลง
            Console.WriteLine("Pow = {0:F2}", Math.Pow(numBer, numBer2)); // x ยกกำลัง y
            Console.WriteLine("Sqrt = {0}", Math.Sqrt(numBer)); // รากที่สองของ x
            Console.WriteLine("Pi = {0:F3}", Math.PI); // ค่าคงที่ พาย มีค่าประมาณ 3.14 
            Console.WriteLine("E = {0:F3}", Math.E); // ค่าคงที่ e มีค่าประมาณ 2.718
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // ตัวดำเนินการเปรียบเทียบ
            int numBer5 = 100, numBer6 = 200;
            Console.WriteLine("numBer5 = {0}, numBer6 = {1}", numBer5, numBer6);
            Console.WriteLine("numBer5 == numBer6 >> {0}", numBer5 == numBer6);
            Console.WriteLine("numBer5 != numBer6 >> {0}", numBer5 != numBer6);
            Console.WriteLine("numBer5 > numBer6 >> {0}", numBer5 > numBer6);
            Console.WriteLine("numBer5 < numBer6 >> {0}", numBer5 < numBer6);
            Console.WriteLine("numBer5 >= numBer6 >> {0}", numBer5 >= numBer6);
            Console.WriteLine("numBer5 <= numBer6 >> {0}", numBer5 <= numBer6);
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // ตัวดำเนินการเพิ่มค่า - ลดค่า
            int a = 5, b = 13; ;
            // การเพิ่มค่า
            Console.WriteLine("+++++increase value+++++");
            Console.WriteLine("+++prefix");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("prefix = {0}", ++a); // เพิ่มค่าให้ a ก่อน 1 ค่าแล้วนำไปใช้
            Console.WriteLine("last a = {0}", a);
            Console.WriteLine("postfix+++");
            a = 5;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("postfix = {0}", a++); // นำค่าปัจจุบันใน a ไปใช้ก่อนแล้วค่าเพิ่มค่า 1
            Console.WriteLine("lase a = {0}", a);

            // การลดค่า
            Console.WriteLine("-----decrease value-----");
            Console.WriteLine("---prefix");
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("prefix = {0}", --b); // ลดค่าให้ b ก่อน 1 ค่าแล้วนำไปใช้
            Console.WriteLine("lase b = {0}", b);
            Console.WriteLine("postfix---");
            b = 13;
            Console.WriteLine("postfix = {0}", b--); / นำค่าปัจจุบันใน b ไปใช้ก่อนแล้วค่าลดค่า 1
            Console.WriteLine("last b = {0}", b);
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // Compound Assignment
            int x = 10, y = 20;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.WriteLine("x = x + y = "+ (x += y));
            Console.WriteLine("x = x - y = " + (x -= y));
            Console.WriteLine("x = x * y = " + (x *= y));
            Console.WriteLine("x = x / y = " + (x /= y));
            Console.WriteLine("x = x % y = " + (x %= y));
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // การแปลงชนิดข้อมูลด้วย Convert
            // Convert
            string myString = "121";

            // แปลงข้อความเป็นตัวเลข
            byte myByte = Convert.ToByte(myString);
            short myShort = Convert.ToInt16(myString);
            int myInt = Convert.ToInt32(myString);
            long myLong = Convert.ToInt64(myString);

            // ทศนิยม
            float myFloat = Convert.ToSingle(myString);
            double myDouble = Convert.ToDouble(myString);

            // แสดงผล
            Console.WriteLine("string = {0}", myString);
            Console.WriteLine("byte = {0}", myByte);
            Console.WriteLine("short = {0}", myShort);
            Console.WriteLine("int = {0}", myInt);
            Console.WriteLine("long = {0}", myLong);
            Console.WriteLine("float = {0}", myFloat);
            Console.WriteLine("double = {0}", myDouble);
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // การแปลงชนิดข้อมูลด้วย Parse
            // Parse

            // input
            string myString = "127";

            // process
            byte myByte = Byte.Parse(myString);
            short myShort = short.Parse(myString);
            int myInt = int.Parse(myString);
            long myLong = long.Parse(myString);
            float myFloat = float.Parse(myString);
            double myDouble = double.Parse(myString);

            //output
            Console.WriteLine("string = {0}", myString + 2);
            Console.WriteLine("byte = {0}", myByte);
            Console.WriteLine("short = {0}", myShort);
            Console.WriteLine("int = {0}", myInt);
            Console.WriteLine("long = {0}", myLong);
            Console.WriteLine("float = {0}", myFloat);
            Console.WriteLine("double = {0}", myDouble);
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // โปรแกรมคำนวณ BMI
            double weight, height; // กำหนดตัวแปร weight และ height เพื่อรับค่าน้ำหนักและส่วนสูงที่ผู้ใช้ป้อนเข้ามา โดยใช้ double เป็นชนิดของตัวแปรเพื่อรองรับตัวเลขทศนิยม.

            // input
            Console.Write("Input Weight (kg):"); // ขอค่าน้ำหนักจากผู้ใช้ โดยแสดงข้อความ "Input Weight (kg):" เพื่อแจ้งให้ผู้ใช้ป้อนค่าน้ำหนักในหน่วยกิโลกรัม
            double.TryParse(Console.ReadLine(), out weight); // แปลงค่าที่ผู้ใช้ป้อนเป็นตัวเลขทศนิยมและเก็บไว้ในตัวแปร weight.

            Console.Write("Input Height (cm):"); // ขอค่าส่วนสูงจากผู้ใช้ โดยแสดงข้อความ "Input Height (cm):" เพื่อแจ้งให้ผู้ใช้ป้อนค่าส่วนสูงในหน่วยเซนติเมตร
            double.TryParse(Console.ReadLine(),out height); // แปลงค่าที่ผู้ใช้ป้อนเป็นตัวเลขทศนิยมและเก็บไว้ในตัวแปร height.

            // process
            // bmi = weight/height^2
            height /= 100; // ทำการแปลงหน่วยของส่วนสูงจากเซนติเมตรเป็นเมตร โดยหารค่า height ด้วย 100 เพื่อให้ได้ค่าส่วนสูงในหน่วยเมตรเพื่อนำไปใช้คำนวณ BMI ในหน่วยเมตร.
            double bmi = weight / Math.Pow(height, 2); // คำนวณค่า BMI โดยใช้สูตร bmi = weight / height^2 และเก็บผลลัพธ์ไว้ในตัวแปร bmi

            // output
            Console.WriteLine("BMI = {0:F2}", bmi); // แสดงผลลัพธ์ค่า BMI ที่คำนวณได้ด้วยข้อความ "BMI = {0:F2}" โดยแสดงค่าเป็นทศนิยม 2 ตำแหน่ง 
            Console.ReadKey(); // เพื่อให้โปรแกรมค้างอยู่ในหน้าต่างคอนโซลจนกว่าผู้ใช้จะกดปุ่มใดๆ เพื่อปิดหน้าต่างโปรแกรม.
            */

            //---------------------------------------------------------------------------------

            /*
            // if else แบบหลายเงื่อนไข
            // input
            int score;
            Console.Write("Input Score :");
            int.TryParse(Console.ReadLine(), out score);

            // process & output
            if (score >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 70) 
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade c");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }

            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // ตัวดำเนินการทางตรรกศาสตร์
            string gender = "male";
            int height = 160;

            // AND และ &&
            if (gender == "male" && height >= 160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }

            // OR หรือ ||
            if (gender == "male" || height >= 160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }

            // Not ไม่ !
            if (!(gender == "male"))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not Pass");
            }

            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // โปรแกรมตัดเกรดอย่างง่าย
            // input
            int score; // กำหนดตัวแปร score และ grade เพื่อเก็บคะแนนที่ผู้ใช้ป้อนเข้ามาและเกรดที่คำนวณได้ โดย score เป็นชนิดของตัวแปร int ใช้สำหรับจำนวนเต็ม และ grade เป็นชนิดของตัวแปร string ใช้สำหรับเก็บข้อความ (เกรด).
            string grade;
            Console.Write("Input score :")
            int.TryParse(Console.ReadLine(), out score); // ขอคะแนนที่ผู้ใช้ป้อนผ่านคอนโซลโดยใช้ Console.ReadLine() เพื่อรับข้อมูลที่ผู้ใช้ป้อน จากนั้นใช้ int.TryParse เพื่อแปลงข้อมูลที่ผู้ใช้ป้อนเป็นตัวเลขและเก็บค่าไว้ในตัวแปร score.

            // process & output
            // คำนวณเกรดของนักเรียนตามคะแนนที่รับเข้ามา โดยใช้โครงสร้างคำสั่งเงื่อนไข (if-else) ซึ่งเช็คคะแนนที่ผู้ใช้ป้อนว่าอยู่ในช่วงไหน แล้วกำหนดเกรดตามเงื่อนไขดังนี้:
            if (score >= 80 && score <= 100) // ถ้าคะแนนอยู่ในช่วง 80-100 จะได้เกรด A
            {
                grade = "A";
            } else if (score >= 70 && score <= 79) // ถ้าคะแนนอยู่ในช่วง 70-79 จะได้เกรด B
            {
                grade = "B";
            } else if (score >= 60 &&  score <= 69) // ถ้าคะแนนอยู่ในช่วง 60-69 จะได้เกรด C
            {
                grade = "C";
            } else if (score >= 50 && score <= 59) // ถ้าคะแนนอยู่ในช่วง 50-59 จะได้เกรด D
            {
                grade = "D";
            } else if (score < 50) // ถ้าคะแนนน้อยกว่า 50 จะได้เกรด F
            {
                grade = "F";
            } else
            {
                grade = "Not Data";
            }

            Console.WriteLine("score = {0}, grade = {1}", score, grade); // แสดงผลลัพธ์ของคะแนนที่ผู้ใช้ป้อนและเกรดที่คำนวณได้ผ่านคอนโซล โดยใช้ Console.WriteLine
            Console.ReadKey(); // เพื่อคอยรับคำสั่งกดปุ่มจากผู้ใช้ก่อนจบโปรแกรม ทำให้โปรแกรมค้างอยู่ในหน้าต่างคอนโซลจนกว่าผู้ใช้จะกดปุ่มใดๆ เพื่อปิดหน้าต่างโปรแกรม
            */

            //---------------------------------------------------------------------------------

            /*
            // การเขียน if ซ้อน if 
            // input
            int money = 30000;  // ตัวแปร money ถูกกำหนดค่าเป็น 30000.

            // process & output
            if (money >= 15000)  // เมื่อถูกนำมาตรวจสอบใน if statement แรก (if (money >= 15000)) เงื่อนไขคือเช็คว่า money มีค่ามากกว่าหรือเท่ากับ 15000 หรือไม่ ในกรณีนี้ค่า money เป็น 30000 ซึ่งมีค่ามากกว่า 15000 จึงเป็นจริง
            {
                Console.WriteLine("Sale!!");
                if (money == 15000)   // การเข้าสู่ if-else statement ซ้อนอีกชุด ในกรณีนี้เป็น if-else statement ในลักษณะของเงื่อนไขต่อเงื่อนไข (if-else if-else) ซึ่งจะตรวจสอบค่าของตัวแปร money เพื่อกำหนดลำดับและแสดงผลลัพธ์ที่เกี่ยวข้องกับค่านั้น
                {
                    Console.WriteLine("Sale = 10%");
                } else if (money == 20000)
                {
                    Console.WriteLine("Sale = 20%");
                } else if(money == 30000)
                {
                    Console.WriteLine("Sale = 30%");
                }
            }
            else
            {
                Console.WriteLine("Not Sale");
            }
            Console.ReadKey();
            // สรุปคือ โค้ดนี้จะตรวจสอบค่าของตัวแปร money และแสดงผลลัพธ์ที่เกี่ยวข้องกับค่านั้น ถ้า money มีค่ามากกว่าหรือเท่ากับ 15000 จะแสดงข้อความ "Sale!!" และตรวจสอบค่าของ money เพื่อแสดงผลลัพธ์ตามลำดับที่กำหนดใน if-else statement ซ้อน ถ้า money มีค่าน้อยกว่า 15000 จะแสดงข้อความ "Not Sale" แทน
            */

            //---------------------------------------------------------------------------------

            /*
            // Switch Case
            // Switch เป็นคำสั่งที่ใช้กำหนดเงื่อนไขคล้ายๆกับ if แต่จะเลือกเพียงหนึ่งทางเลือกออกมาทำงานโดยนำค่าในตัวแปรมากำหนดเป็นทางเลือกผ่านคำสั่ง Case

            // input
            int number1, number2, choice; // ประกาศตัวแปร number1, number2, และ choice สำหรับใช้เก็บค่าที่ผู้ใช้ป้อนเข้ามาในโปรแกรม
            Console.Write("Input Number1 = "); // ข้อความ "Input Number1 = " จะถูกแสดงทางหน้าจอ และผู้ใช้จะถูกขอให้ป้อนค่าตัวเลขเพื่อกำหนดค่าให้กับ number1.
            int.TryParse(Console.ReadLine(), out number1);  // โค้ด int.TryParse(Console.ReadLine(), out number1); จะอ่านค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และพยายามแปลงค่านั้นเป็นตัวเลข หากการแปลงสำเร็จ ค่าจะถูกเก็บใน number1 และหากไม่สำเร็จ ค่าใน number1 จะเป็น 0.
            Console.Write("Input Number2 = "); // ข้อความ "Input Number2 = " จะถูกแสดงทางหน้าจอ และผู้ใช้จะถูกขอให้ป้อนค่าตัวเลขเพื่อกำหนดค่าให้กับ number2.
            int.TryParse(Console.ReadLine(), out number2); // โค้ด int.TryParse(Console.ReadLine(), out number2); จะอ่านค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และพยายามแปลงค่านั้นเป็นตัวเลข หากการแปลงสำเร็จ ค่าจะถูกเก็บใน number2 และหากไม่สำเร็จ ค่าใน number2 จะเป็น 0.
            Console.Write("Input Choice(1(+),2(-)) = "); // ข้อความ "Input Choice(1(+),2(-)) = " จะถูกแสดงทางหน้าจอ และผู้ใช้จะถูกขอให้ป้อนค่าตัวเลขเพื่อกำหนดค่าให้กับ choice.
            int.TryParse(Console.ReadLine(), out choice); // โค้ด int.TryParse(Console.ReadLine(), out choice); จะอ่านค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และพยายามแปลงค่านั้นเป็นตัวเลข หากการแปลงสำเร็จ ค่าจะถูกเก็บใน choice และหากไม่สำเร็จ ค่าใน choice จะเป็น 0.

            // process & output
            switch (choice) // เมื่อค่าของ choice ถูกกำหนดแล้ว โค้ด switch (choice) จะตรวจสอบค่าของ choice เพื่อเปรียบเทียบกับ case ที่กำหนดไว้.
            {
                case 1: Console.WriteLine("+"); // case 1: ถ้า choice เท่ากับ 1 จะแสดงข้อความ "+" ออกทางหน้าจอ
                    break;
                case 2: Console.WriteLine("-"); // case 2: ถ้า choice เท่ากับ 2 จะแสดงข้อความ "-" ออกทางหน้าจอ
                    break;
                default: Console.WriteLine("Error"); // หากค่าของ choice ไม่ตรงกับ case ใดเลย (ไม่ใช่ 1 และไม่ใช่ 2) คำสั่งใน default จะถูกเรียกใช้งาน ซึ่งจะแสดงข้อความ "Error" ออกทางหน้าจอ
                    break;
            }
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // While Loop แม่สูตรคูณ
            // input 
            int mt; // ประกาศตัวแปร mt สำหรับใช้เก็บค่าที่ผู้ใช้ป้อนเข้ามาในโปรแกรม.
            Console.Write("Input multiplication table : "); // ข้อความ "Input multiplication table : " จะถูกแสดงทางหน้าจอ และผู้ใช้จะถูกขอให้ป้อนค่าตัวเลขที่ต้องการดูแม่สูตรคูณ.
            int.TryParse(Console.ReadLine(), out mt); // อ่านค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และพยายามแปลงค่านั้นเป็นตัวเลข หากการแปลงสำเร็จ ค่าจะถูกเก็บใน mt และหากไม่สำเร็จ ค่าใน mt จะเป็น 0.
            int count = 1; // ประกาศตัวแปร count และกำหนดค่าเริ่มต้นให้เป็น 1 ในการคำนวณแม่สูตรคูณ.
            while (count <= 12) // เมื่อ count มีค่าน้อยกว่าหรือเท่ากับ 12 โค้ดใน block ของ while loop จะถูกทำซ้ำไปเรื่อยๆ ซึ่งจะทำแม่สูตรคูณเริ่มต้นจาก 1 ถึง 12 แสดงผลลัพธ์บนหน้าจอ
            {
                Console.WriteLine("{0} x {1} = {2}",mt ,count, mt * count); // แสดงข้อความที่แสดงแม่สูตรคูณในรูปแบบ "ตัวเลขที่ต้องการดูแม่สูตร x ตัวเลขในแม่สูตร = ผลคูณ" เช่นถ้าผู้ใช้ป้อนค่า mt
                count++; // เพิ่มค่าของ count ทีละ 1 เพื่อให้วนลูปไปตามแม่สูตรคูณได้ถูกต้อง และทำให้เงื่อนไขใน while loop เป็นเท็จเมื่อ count เกินค่า 12
            }
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // For Loop
            // For Loop เป็นรูปแบบการซ้ำที่ใช้ในการตรวจสอบเงื่อนไขการทำงาน มีการกำหนดค่าเริ่มต้นและเปลี่ยนค่าไปพร้อมๆกัน เมื่อเงื่อนไขในคำสั่ง For เป็นจริง
            // ก็จะทำงานตามคำสั่งที่แสดงไว้ภายในคำสั่ง For ไปเรื่อยๆ

            // input
            int number; // ประกาศตัวแปร number สำหรับใช้เก็บค่าที่ผู้ใช้ป้อนเข้ามาในโปรแกรม.
            Console.Write("Input Number : "); // ข้อความ "Input Number : " จะถูกแสดงทางหน้าจอ และผู้ใช้จะถูกขอให้ป้อนค่าตัวเลข.
            int.TryParse(Console.ReadLine(), out number); // อ่านค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และพยายามแปลงค่านั้นเป็นตัวเลข หากการแปลงสำเร็จ ค่าจะถูกเก็บใน number และหากไม่สำเร็จ ค่าใน number จะเป็น 0.

            // process & output
            for (int count = 1;count <= 12 ; count++) // กำหนดค่าเริ่มต้นของตัวแปร count ให้เป็น 1 (int count = 1) เพื่อใช้ในการคำนวณแม่สูตรคูณ.
            // เงื่อนไขของ for loop คือ count <= 12 หากเงื่อนไขนี้เป็นจริง คำสั่งใน for loop จะถูกทำซ้ำเรื่อยๆ ซึ่งจะทำแม่สูตรคูณเริ่มต้นจาก 1 ถึง 12 แสดงผลลัพธ์บนหน้าจอ.
            {
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count); // แสดงข้อความที่แสดงแม่สูตรคูณในรูปแบบ "ตัวเลขที่ผู้ใช้ป้อนเข้ามา x ตัวเลขในแม่สูตร = ผลคูณ" เช่นถ้าผู้ใช้ป้อนค่า number
            }
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // Do While
            // Do While โปรแกรมจะทำงานตามคำสั่งอย่างน้อย 1 รอบ เมื่อทำงานเสร็จจะมาตรวจสอบเงื่อนไขที่คำสั่ง While ถ้าเงื่อนไขเป็นจริง
            // จะวนกลับขึ้นไปทำงานที่คำสั่งใหม่อีกรอบ แต่ถ้าเป็นเท็จจะหลุดออกจากลูป
            
            // input
            int count = 1;

            // process
            do
            {
                Console.WriteLine("Hello World = {0}", count);
                count++;
            }
            while (count <= 3);

            // output
            Console.WriteLine("End Program");
            Console.ReadKey();
            */

            //---------------------------------------------------------------------------------

            /*
            // Break & Continue
            // คำสั่งที่เกี่ยวข้องกับ Loop
            // break ถ้าโปรแกรมพบคำสั่งนี้จะหลุดจากการทำงานในลูปทันทีเพื่อไปทำคำสั่งอื่นที่นอกลูป
            // continue คำสั่งนี้จะทำให้หยุดการทำงานแล้วย้อนกลับไปเริ่มต้นการทำงานที่ต้นลูปใหม่

            // input 
            int number;
            Console.Write("Input Number : ");
            int.TryParse(Console.ReadLine(), out number);

            // process & output
            for (int count = 1; count <= 12; count++)
            {
                if (count == 5)
                {
                    break;
                }
                Console.WriteLine("{0} x {1} = {2}", number, count, number * count);
            }
            Console.WriteLine("End Program");
            Console.ReadLine();
            */

            //---------------------------------------------------------------------------------

            /*
             ข้อแตกต่างและการใช้งาน Loop
            - For ใช้ในกรณีรู้จำนวนรอบที่ชัดเจน
            - While ใช้ในกรณีที่ไม่รู้จำนวนรอบ
            - Do..While ใช้ในกรณีที่อยากให้ลองทำก่อน 1 รอบแล้วทำซ้ำเรื่อยๆตราบเท่าที่เงื่อนไขเป็นจริง
            */

            //---------------------------------------------------------------------------------

            /*
            // ทำโจทย์ปัญหา : หาผลรวมและค่าเฉลี่ย
            - จำนวนตัวเลข : 5 จำนวน (n = 5)
            - รับค่าตัวเลขผ่านแป้นพิมพ์
            - แสดงผลรวมตัวเลข 5 จำนวน (summation)
            - แสดงค่าเฉลี่ยตัวเลขจากสมการ
            average = summation / n
            */
            /*
            int sum = 0, avg = 0;  // กำหนดค่าตัวแปร "sum" และ "avg" เป็น 0 ที่จะใช้เก็บผลรวมและค่าเฉลี่ยของตัวเลขที่รับเข้ามา
            for (int count = 1; count <= 5; count++) // ทำการทำงานในลูป "for" ที่จะทำงานทั้งหมด 5 รอบ (count คือ 1 ถึง 5):
            {
                int number;  // กำหนดตัวแปรชื่อ "number" เพื่อเก็บค่าตัวเลขที่ผู้ใช้ป้อนเข้ามา
                Console.Write("Input Number = ");  // แสดงข้อความ "Input Number = " ในหน้าจอคอนโซลเพื่อแสดงให้ผู้ใช้ป้อนค่าตัวเลข
                int.TryParse(Console.ReadLine(), out number); // รับค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และ int.TryParse() ในการแปลงค่าที่รับเข้ามาเป็นตัวเลขและเก็บไว้ในตัวแปร "number"
                sum += number; // นำค่าที่ได้รับมาบวกกับตัวแปร "sum" ซึ่งเป็นตัวแปรที่ใช้เก็บผลรวมของตัวเลขที่ผู้ใช้ป้อนเข้ามาในแต่ละรอบ
            }
            Console.WriteLine("Summation = {0}", sum); // แสดงผลรวมของตัวเลขที่ผู้ใช้ป้อนเข้ามา
            Console.ReadKey();
            */

            //------------------------------------------------------------------------

            /*
            // ทำโจทย์ปัญหา : หาผลรวมและค่าเฉลี่ย (ไม่จำกัดจำนวน)
            - จำนวนตัวเลข : ไม่จำกัดจำนวน (n)
            - รับค่าตัวเลขผ่านแป้นพิมพ์
            - ถ้าป้อนเลขติดลบให้จบการทำงาน
            - แสดงผลตัวเลขตามจำนวนที่ป้อน (summation)
            - แสดงค่าเฉลี่ยตัวเลขจากสมการ
            average = summation / n
            */
            /*
            int sum = 0, avg = 0; // กำหนดค่าตัวแปร "sum" และ "avg" เป็น 0 ที่จะใช้เก็บผลรวมและค่าเฉลี่ยของตัวเลขที่รับเข้ามา
            int count = 0; // กำหนดค่าเริ่มต้นของตัวแปร "count" เป็น 0 ที่จะใช้เก็บจำนวนตัวเลขที่รับเข้ามา
            while (true) // เข้าสู่ลูป "while (true)" ซึ่งจะเป็นลูปที่ทำงานแบบไม่มีเงื่อนไขในการหยุด ดังนั้นจะทำงานตลอดเวลาจนกว่าจะมีคำสั่ง break ในลูปซึ่งจะทำให้ลูปหยุดทำงาน
            {
                int number; // กำหนดตัวแปรชื่อ "number" เพื่อเก็บค่าตัวเลขที่ผู้ใช้ป้อนเข้ามา
                Console.Write("Input Number = "); // แสดงข้อความ "Input Number = " ในหน้าจอคอนโซลเพื่อแสดงให้ผู้ใช้ป้อนค่าตัวเลข
                int.TryParse(Console.ReadLine(), out number); // ใช้ Console.ReadLine() เพื่อรับค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และ int.TryParse() ในการแปลงค่าที่รับเข้ามาเป็นตัวเลขและเก็บไว้ในตัวแปร "number"
                if (number < 0) // ตรวจสอบว่าถ้าค่าที่ผู้ใช้ป้อนเข้ามา (ตัวแปร "number") น้อยกว่า 0 แสดงว่าผู้ใช้ป้อนค่าติดลบ จึงทำการ break ในลูป (break คือคำสั่งในการออกจากลูปทันที)
                                // หากค่าที่ผู้ใช้ป้อนเข้ามาไม่ใช่ค่าติดลบ ก็จะทำการบวกค่าตัวแปร "count" ขึ้นไปอีก 1 (เพื่อนับจำนวนตัวเลขที่รับเข้ามา) และนำค่าที่ผู้ใช้ป้อนเข้ามาบวกกับตัวแปร "sum" ซึ่งเป็นตัวแปรที่ใช้เก็บผลรวมของตัวเลขที่ผู้ใช้ป้อนเข้ามาในแต่ละรอบ
                                // เมื่อผู้ใช้ป้อนค่าติดลบ (หรือค่าอื่นๆ) ลูป "while (true)" จะหยุดทำงาน และโค้ดจะทำงานต่อที่คำสั่งถัดไป
                {
                    break;
                }
                count++;
                sum += number;
            }
            Console.WriteLine("Summation = {0}", sum);
            avg = sum / count;  // ทำการคำนวณค่าเฉลี่ยของตัวเลขที่ผู้ใช้ป้อนเข้ามาและเก็บในตัวแปร "avg" โดยใช้สูตร "sum / count" ซึ่ง sum คือผลรวมของตัวเลขทั้งหมดและ count คือจำนวนตัวเลขที่ผู้ใช้ป้อนเข้ามา
            Console.WriteLine("Average = {0}", avg);
            Console.ReadKey();
            */

            //------------------------------------------------------------------------

            /*
             // ทำโจทย์ปัญหา : หาผลรวมและค่าเฉลี่ย (ไม่จำกัดจำนวน)
            - จำนวนตัวเลข : ไม่จำกัด (n)
            - รับค่าตัวเลขผ่านแป้นพิมพ์
            - ถ้าป้อนเลขติดลบให้จบการทำงาน
            - ตรวจสอบว่าเลขที่ป้อนมีค่าสูงสุดเท่าใด
            - ตรวจสอบว่าเลขที่ป้อนมีค่าต่ำสุดเท่าใด
            */
            /*
            int minNumber = 0, maxNumber = 0; // กำหนดค่าตัวแปร "minNumber" และ "maxNumber" เป็น 0 ที่จะใช้เก็บค่าตัวเลขที่น้อยที่สุดและมากที่สุดที่ผู้ใช้ป้อนเข้ามา โดยตั้งค่าเริ่มต้นเป็น 0 เพื่อให้สามารถทำงานได้ถูกต้องถ้าไม่มีตัวเลขที่ผู้ใช้ป้อนเข้ามาเลย
            while (true) // เข้าสู่ลูป "while (true)" ซึ่งจะเป็นลูปที่ทำงานแบบไม่มีเงื่อนไขในการหยุด ดังนั้นจะทำงานตลอดเวลาจนกว่าจะมีคำสั่ง break ในลูปซึ่งจะทำให้ลูปหยุดทำงาน
            {
                int number; // กำหนดตัวแปรชื่อ "number" เพื่อเก็บค่าตัวเลขที่ผู้ใช้ป้อนเข้ามา
                Console.Write("Input Number = "); // แสดงข้อความ "Input Number = " ในหน้าจอคอนโซลเพื่อแสดงให้ผู้ใช้ป้อนค่าตัวเลข
                int.TryParse(Console.ReadLine(), out number); // ใช้ Console.ReadLine() เพื่อรับค่าที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และ int.TryParse() ในการแปลงค่าที่รับเข้ามาเป็นตัวเลขและเก็บไว้ในตัวแปร "number"
                if (number < 0) // ตรวจสอบว่าถ้าค่าที่ผู้ใช้ป้อนเข้ามา (ตัวแปร "number") น้อยกว่า 0 แสดงว่าผู้ใช้ป้อนค่าติดลบ จึงทำการ break ในลูป (break คือคำสั่งในการออกจากลูปทันที)
                {
                    break;
                }
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
                // หากค่าที่ผู้ใช้ป้อนเข้ามาไม่ใช่ค่าติดลบ โค้ดจะทำการเปรียบเทียบค่านั้นกับค่าที่เป็นค่าน้อยที่สุด (minNumber) และค่าที่เป็นค่ามากที่สุด (maxNumber) ซึ่งเริ่มต้นเป็น 0 ทั้งคู่
                // หากค่าที่ผู้ใช้ป้อนเข้ามามากกว่าค่าที่เป็นค่ามากที่สุด (maxNumber) ก็จะทำการอัปเดตค่าของ maxNumber เป็นค่านั้น
                // หากค่าที่ผู้ใช้ป้อนเข้ามาน้อยกว่าค่าที่เป็นค่าน้อยที่สุด (minNumber) ก็จะทำการอัปเดตค่าของ minNumber เป็นค่านั้น
            }
            Console.WriteLine("Max = {0}", maxNumber);
            Console.WriteLine("Min = {0}", minNumber);
            Console.ReadKey();
            */

            //------------------------------------------------------------------------

            /*
             // ทำโจทย์ปัญหา : การจ่ายธนบัตรของ ATM
            - รับตัวเลข 100 เป็นต้นไป
            - ตู้ ATM จะจ่ายธนบัตรฉบับละ 100, 500, 1000 บาทเท่านั้น
            - ถ้าป้อนเลขหลักหน่วย - หลักสิบจะให้กลับไปป้อนจำนวนเงินอีกครั้ง
            */
            /*
            int money; // กำหนดตัวแปร "money" ที่ใช้เก็บค่าจำนวนเงินที่ผู้ใช้ป้อนเข้ามา
            do // เข้าสู่ลูป "do-while" ที่จะทำงานอย่างน้อย 1 รอบและทำซ้ำไปเรื่อยๆ ตามเงื่อนไขในคำสั่ง while จนกว่าจะเป็นจริง คือต้องการให้ผู้ใช้ป้อนจำนวนเงินที่เป็นหลักร้อย (มีหน่วยเป็น 100) ถึงจะออกจากลูป
            {
                Console.Write("Input Money = "); // แสดงข้อความ "Input Money = " ในหน้าจอคอนโซลเพื่อให้ผู้ใช้ป้อนค่าจำนวนเงิน
                int.TryParse(Console.ReadLine(), out money);  // ทำการรับค่าจำนวนเงินที่ผู้ใช้ป้อนเข้ามาจากคีย์บอร์ด และใช้ int.TryParse() ในการแปลงค่าที่รับเข้ามาเป็นตัวเลขและเก็บในตัวแปร "money"
            } while (money % 100 != 0); // ตรวจสอบเงื่อนไขที่ "money % 100 != 0" ถ้าเงื่อนไขเป็นจริง (ค่าในตัวแปร "money" ไม่เป็นหลักร้อย) ก็จะวนลูปไปทำข้อความและการรับค่าใหม่อีกครั้ง
            Console.WriteLine("Money = {0}", money); 
            Console.WriteLine("1000 Baht = {0}", money / 1000); // แสดงผลลัพธ์ในหน่วยพันบาท (1000 Baht) โดยให้ผลการหาร "money" ด้วย 1000 และแสดงผลในรูปแบบ "1000 Baht = {0}"
            money %= 1000; // ทำการคำนวณเหลือเงินที่เป็นหลักร้อยเหลือทิ้ง (money %= 1000) ซึ่งเป็นการกำหนดค่าใหม่ให้กับตัวแปร "money" โดยให้เท่ากับเศษที่เหลือจากการหาร "money" ด้วย 1000 ซึ่งเป็นจำนวนเงินที่เหลือหลังจากนำแบงค์ 1000 บาทออก
            Console.WriteLine("500 Baht = {0}", money / 500); // ทำการแสดงผลลัพธ์ในหน่วยห้าร้อยบาท (500 Baht) โดยให้ผลการหาร "money" ด้วย 500 และแสดงผลในรูปแบบ "500 Baht = {0}"
            money %= 500;
            Console.WriteLine("100 Baht = {0}", money / 100); // ทำการคำนวณเหลือเงินที่เป็นหลักสิบบาท (100 Baht) โดยให้ผลการหาร "money" ด้วย 100 และแสดงผลในรูปแบบ "100 Baht = {0}"
            Console.ReadKey();
            */
        }
    }
}
