#1. โปรแกรมส่วนที่ 1 หมวดเก็บข้อมูลอ้างอิง
#1.1 เก็บ Tier ของยอดขาย
Tier1 = range (0, 150001)
Tier2 = range (150001, 200001)
Tier3 = range (200001, 500001)

#1.2 เก็บข้อมูลและ Income ของ Tier1 หมายเหตุ : List[0] คือเปอร์เซ็นต์ List[1] เก็บช่วงของยอดขาย
Tier1_1 = [0.04, range (0, 40001)] #0.4 คือ 4% มาจาก 4/100 = 0.04
Tier1_2 = [0.06, range (40001, 70001)]
Tier1_3 = [0.08, range (70001, 90001)]
Tier1_4 = [0.1, range (90001, 100001)]
Tier1_5 = [0.15, range (100001, 200001)]

#1.3 เก็บข้อมูลและ Income ของ Tier2
Tier2_1 = [0.05, range (0, 40001)]
Tier2_2 = [0.06, range (40001, 90001)]
Tier2_3 = [0.09, range (90001, 150001)]
Tier2_4 = [0.1, range (150001, 200001)]
Tier2_5 = [0.14, range (200001, 999999)]

#1.4 เก็บข้อมูลและ Income ของ Tier3
Tier3_1 = [0.03, range (0, 70001)]
Tier3_2 = [0.04, range (70001, 100001)]
Tier3_3 = [0.08, range (100001, 150001)]
Tier3_4 = [0.11, range (150001, 250001)]
Tier3_5 = [0.13, range (250001, 999999)]

#1.5 ตัวแปรเก็บข้อมูลอินพุท
SalesName = []          # เก็บชื่อคนขายประกัน
SalesVolume = []        # เก็บยอดขายประกัน
Target = []             # เก็บยอดเป้าหมาย
Tier = []               # เก็บเทียร์
PercentIncentive = []   # เก็บ %Incentive
Incentive = []          # เก็บ Incentive ที่ได้


#.........................................จบโปรแกรมส่วนที่ 1.........................................#


#โปรแกรมส่วนที่ 2 หมวด Algorithm
#Start Program
print ("ใส่ชื่อและยอดขายของคุณ หากกรอกเลข '0000' เป็นการจบโปรแกรม")

#รับค่าชื่อ Sales
while True:
    sales_input = str(input("ชื่อ : "))
    SalesName.append(sales_input)

    #กรอก 0000 จบโปรแกรม
    if sales_input == "0000":
        print ("จบโปรแกรม")
        SalesName = SalesName[:-1]
        break
    
    #รับค่ายอดขาย
    sales_volume = int(input("ยอดขาย : "))
    SalesVolume.append(sales_volume)

    #รับค่า Target
    sales_target = int(input("Target : "))
    
    #ตรวจสอบ Target จากข้อ 1.1
    # == Tier1 Program == #
    if sales_target in Tier1:
        Tier.append(1)
        Target.append(sales_target)
        #คำนวน Incentive Tier1
        if sales_volume in Tier1_1[1]:
            Incentive.append(Tier1_1[0]*sales_volume)
            PercentIncentive.append(Tier1_1[0])
        elif sales_volume in Tier1_2[1]:
            Incentive.append(Tier1_2[0]*sales_volume)
            PercentIncentive.append(Tier1_2[0])
        elif sales_volume in Tier1_3[1]:
            Incentive.append(Tier1_3[0]*sales_volume)
            PercentIncentive.append(Tier1_3[0])
        elif sales_volume in Tier1_4[1]:
            Incentive.append(Tier1_4[0]*sales_volume)
            PercentIncentive.append(Tier1_4[0])
        elif sales_volume in Tier1_5[1]:
            Incentive.append(Tier1_5[0]*sales_volume)
            PercentIncentive.append(Tier1_5[0])

    # == Tier2 Program == #
    if sales_target in Tier2:
        Tier.append(2)
        Target.append(sales_target)
        #คำนวน Incentive Tier2
        if sales_volume in Tier2_1[1]:
            Incentive.append(Tier2_1[0]*sales_volume)
            PercentIncentive.append(Tier2_1[0])
        elif sales_volume in Tier2_2[1]:
            Incentive.append(Tier2_2[0]*sales_volume)
            PercentIncentive.append(Tier2_2[0])
        elif sales_volume in Tier2_3[1]:
            Incentive.append(Tier2_3[0]*sales_volume)
            PercentIncentive.append(Tier2_3[0])
        elif sales_volume in Tier2_4[1]:
            Incentive.append(Tier2_4[0]*sales_volume)
            PercentIncentive.append(Tier2_4[0])
        elif sales_volume in Tier2_5[1]:
            Incentive.append(Tier2_5[0]*sales_volume)
            PercentIncentive.append(Tier2_5[0])

    # == Tier3 Program == #
    if sales_target in Tier3:
        Tier.append(3)
        Target.append(sales_target)
        #คำนวน Incentive Tier3
        if sales_volume in Tier3_1[1]:
            Incentive.append(Tier3_1[0]*sales_volume)
            PercentIncentive.append(Tier3_1[0])
        elif sales_volume in Tier3_2[1]:
            Incentive.append(Tier3_2[0]*sales_volume)
            PercentIncentive.append(Tier3_2[0])
        elif sales_volume in Tier3_3[1]:
            Incentive.append(Tier3_3[0]*sales_volume)
            PercentIncentive.append(Tier3_3[0])
        elif sales_volume in Tier3_4[1]:
            Incentive.append(Tier3_4[0]*sales_volume)
            PercentIncentive.append(Tier3_4[0])
        elif sales_volume in Tier3_5[1]:
            Incentive.append(Tier3_5[0]*sales_volume)
            PercentIncentive.append(Tier3_5[0])    


#.........................................จบโปรแกรมส่วนที่ 2.........................................#
 

    #โปรแกรมส่วนที่ 3 หมวดการแสดงผล
    print ("ชื่อ : ", SalesName)
    print ("ยอดขาย : ", SalesVolume)
    print ("Target : ", Target)
    print ("Tier : " , Tier)
    print ("%Incentive : ", PercentIncentive)
    print ("Incentive : ", Incentive)
    print ()


#.........................................จบโปรแกรมส่วนที่ 3.........................................#


#โปรแกรมส่วนที่ 4 ส่วน Export csv
import pandas as pd

#Create Column
data = {"SalesName" : SalesName, 
        "SalesAmount" : SalesVolume,
        "Target" : Target,
        "Tier" : Tier,
        "%Incentive" : PercentIncentive,
        "Incentive" : Incentive}

#Create DataFrame & Save files .csv
df = pd.DataFrame(data)
df.to_csv('incentive_csv.csv')
df.to_excel('incentive_excel.xlsx')

#.........................................จบโปรแกรมส่วนที่ 4.........................................#