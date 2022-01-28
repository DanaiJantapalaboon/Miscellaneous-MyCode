using System.Runtime.InteropServices;
using System.Reflection;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using Internal;
using System.Collections.Generic;
using System.Linq; //Linq = Language-Integrated Query (LINQ) contains Enumerable.Range
using System;

namespace Program {
    class Incentive {
        static void Main (string[] args) {
            //1. โปรแกรมส่วนที่ 1 หมวดเก็บข้อมูลอ้างอิง
            //1.1 เก็บ Tier ของยอดขาย
            IEnumerable<int> Tier1 = Enumerable.Range(0, 150001);
            IEnumerable<int> Tier2 = Enumerable.Range(150001, 200001);
            IEnumerable<int> Tier3 = Enumerable.Range(200001, 500001);

            //1.2 เก็บข้อมูลและ Income ของ Tier1 หมายเหตุ : List[0] คือเปอร์เซ็นต์ List[1] เก็บช่วงของยอดขาย
            double[] PercentTier1 = {0.04, 0.06, 0.08, 0.1, 0.15}; //0.4 คือ 4% มาจาก 4/100 = 0.04
            IEnumerable<int> Tier1_1 = Enumerable.Range(0, 40001);
            IEnumerable<int> Tier1_2 = Enumerable.Range(40001, 70001);
            IEnumerable<int> Tier1_3 = Enumerable.Range(70001, 90001);
            IEnumerable<int> Tier1_4 = Enumerable.Range(90001, 100001);
            IEnumerable<int> Tier1_5 = Enumerable.Range(100001, 200001);

            //1.3 เก็บข้อมูลและ Income ของ Tier2
            double[] PercentTier2 = {0.05, 0.06, 0.09, 0.1, 0.14};
            IEnumerable<int> Tier2_1 = Enumerable.Range(0, 40001);
            IEnumerable<int> Tier2_2 = Enumerable.Range(40001, 90001);
            IEnumerable<int> Tier2_3 = Enumerable.Range(90001, 150001);
            IEnumerable<int> Tier2_4 = Enumerable.Range(150001, 200001);
            IEnumerable<int> Tier2_5 = Enumerable.Range(200001, 999999);

            //1.4 เก็บข้อมูลและ Income ของ Tier3
            double[] PercentTier3 = {0.03, 0.04, 0.08, 0.11, 0.13};
            IEnumerable<int> Tier3_1 = Enumerable.Range(0, 70001);
            IEnumerable<int> Tier3_2 = Enumerable.Range(70001, 100001);
            IEnumerable<int> Tier3_3 = Enumerable.Range(100001, 150001);
            IEnumerable<int> Tier3_4 = Enumerable.Range(150001, 250001);
            IEnumerable<int> Tier3_5 = Enumerable.Range(250001, 999999);

            //1.5 ตัวแปร Array เก็บข้อมูลอินพุท (ใช้ LINQ)
            var PercentIncentive = new List<double>(); //เก็บ %Incentive
            var Incentive = new List<double>(); //เก็บ Incentive ที่ได้
            var SalesName = new List<string>();  //เก็บชื่อคนขายประกัน
            var SalesVolume = new List<int>(); //เก็บยอดขายประกัน
            var Target = new List<int>(); //เก็บยอดเป้าหมาย
            var Tier = new List<int>(); //เก็บเทียร์

            //.........................................จบโปรแกรมส่วนที่ 1.........................................#
            //โปรแกรมส่วนที่ 2 หมวด Algorithm
            //Start Program
            Console.WriteLine ("ใส่ชื่อและยอดขายของคุณ หากกรอกเลข '0000' เป็นการจบโปรแกรม");

            //รับค่าชื่อ Sales
            while (true) {
                Console.Write ("ชื่อ : ");
                string sales_input = Console.ReadLine();
                SalesName.Add(sales_input); //เพิ่มชื่อที่กรอกใน var SalesName

                if (sales_input == "0000") {
                    SalesName.RemoveAt(SalesName.Count -1); //กรอก 0000 จบโปรแกรม และตัด 0000 ออกจากรายการ
                    break;
                }
                //รับค่ายอดขาย
                Console.Write ("ยอดขาย : ");
                int sales_volume = Convert.ToInt32(Console.ReadLine());
                SalesVolume.Add(sales_volume);

                //รับค่า Target
                Console.Write ("Target : ");
                int sales_target = Convert.ToInt32(Console.ReadLine());

                //ตรวจสอบ Target จากข้อ 1.1
                // == Tier1 Program == //
                if (Tier1.Contains(sales_target)) {
                    Tier.Add(1);
                    Target.Add(sales_target);

                    //คำนวน Incentive Tier1
                    if (Tier1_1.Contains(sales_volume)) {
                        Incentive.Add(PercentTier1[0]*sales_volume);
                        PercentIncentive.Add(PercentTier1[0]);
                    }
                    else if (Tier1_2.Contains(sales_volume)) {
                        Incentive.Add(PercentTier1[1]*sales_volume);
                        PercentIncentive.Add(PercentTier1[1]);
                    }
                    else if (Tier1_3.Contains(sales_volume)) {
                        Incentive.Add(PercentTier1[2]*sales_volume);
                        PercentIncentive.Add(PercentTier1[2]);
                    }
                    else if (Tier1_4.Contains(sales_volume)) {
                        Incentive.Add(PercentTier1[3]*sales_volume);
                        PercentIncentive.Add(PercentTier1[3]);
                    }
                    else if (Tier1_5.Contains(sales_volume)) {
                        Incentive.Add(PercentTier1[4]*sales_volume);
                        PercentIncentive.Add(PercentTier1[4]);
                    }
                }
                // == Tier2 Program == //
                if (Tier2.Contains(sales_target)) {
                    Tier.Add(2);
                    Target.Add(sales_target);

                    //คำนวณ Incentive Part 2
                    if (Tier2_1.Contains(sales_volume)) {
                        Incentive.Add(PercentTier2[0]*sales_volume);
                        PercentIncentive.Add(PercentTier2[0]);
                    }
                    else if (Tier2_2.Contains(sales_volume)) {
                        Incentive.Add(PercentTier2[1]*sales_volume);
                        PercentIncentive.Add(PercentTier2[1]);
                    }
                    else if (Tier2_3.Contains(sales_volume)) {
                        Incentive.Add(PercentTier2[2]*sales_volume);
                        PercentIncentive.Add(PercentTier2[2]);
                    }
                    else if (Tier2_4.Contains(sales_volume)) {
                        Incentive.Add(PercentTier2[3]*sales_volume);
                        PercentIncentive.Add(PercentTier2[3]);
                    }
                    else if (Tier2_5.Contains(sales_volume)) {
                        Incentive.Add(PercentTier2[4]*sales_volume);
                        PercentIncentive.Add(PercentTier2[4]);
                    }
                }
                // == Tier3 Program == //
                if (Tier3.Contains(sales_target)) {
                    Tier.Add(3);
                    Target.Add(sales_target);

                    //คำนวณ Incentive Part 3
                    if (sales_volume.Contains(Tier3_1)) {
                        Incentive.Add(PercentTier3[0]*sales_volume);
                        PercentIncentive.Add(PercentTier3[0]);
                    }
                    else if (sales_volume.Contains(Tier3_2)) {
                        Incentive.Add(PercentTier3[1]*sales_volume);
                        PercentIncentive.Add(PercentTier3[1]);
                    }
                    else if (sales_volume.Contains(Tier3_3)) {
                        Incentive.Add(PercentTier3[2]*sales_volume);
                        PercentIncentive.Add(PercentTier3[2]);
                    }
                    else if (sales_volume.Contains(Tier3_4)) {
                        Incentive.Add(PercentTier3[3]*sales_volume);
                        PercentIncentive.Add(PercentTier3[3]);
                    }
                    else if (sales_volume.Contains(Tier3_5)) {
                        Incentive.Add(PercentTier3[4]*sales_volume);
                        PercentIncentive.Add(PercentTier3[4]);
                    }
                }
            }
            //.........................................จบโปรแกรมส่วนที่ 2.........................................#
            //โปรแกรมส่วนที่ 3 หมวดการแสดงผล
            Console.WriteLine("ชื่อ : ", SalesName);
            Console.WriteLine("ยอดขาย : ", SalesVolume);
            Console.WriteLine("Target : ", Target);
            Console.WriteLine("Tier : " , Tier);
            Console.WriteLine("%Incentive : ", PercentIncentive);
            Console.WriteLine("Incentive : ", Incentive);
            Console.WriteLine();
            Console.ReadKey();
        
        }
    }
}                   