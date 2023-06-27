import random

def dnaGen(dnaLength = int(input("Enter DNA Length : "))):
    dnaRandom = []
    bases = ['A', 'T', 'C', 'G']

    for i in range(dnaLength):
        i = random.choice(bases)
        dnaRandom.append(i)

    random.shuffle(dnaRandom)
    
    print ("-" *120)
    print ("".join(dnaRandom))

dnaGen()

def baseCount(base_input = str(input("Enter bases : ")).upper().replace(" ", "")):
    countA, countT, countC, countG = 0, 0, 0, 0
    uncount = 0

    for i in base_input:
        if i == 'A': countA += 1
        elif i == 'T': countT += 1
        elif i == 'C': countC += 1
        elif i == 'G': countG += 1
        else: uncount += 1

    print ("-" *120)
    print("Total bases count : {}" .format(len(base_input)))
    print("Count of A : {} ({} %)" .format(countA, round(countA / len(base_input) * 100, 2)))
    print("Count of T : {} ({} %)" .format(countT, round(countT / len(base_input) * 100, 2)))
    print("Count of C : {} ({} %)" .format(countC, round(countC / len(base_input) * 100, 2)))
    print("Count of G : {} ({} %)" .format(countG, round(countG / len(base_input) * 100, 2)))
    print("Uncount : {}" .format(uncount))

baseCount()

def baseMismatch():
    template = str(input("Enter DNA Template : ")).upper().replace(" ", "")
    compare =  str(input("Enter DNA Compare : ")).upper().replace(" ", "")
    compare_slice = (compare[:len(template)])
    template_slice = (template[:len(compare)])

    mismatchCount = 0
    mismatchIndex = []

    for i in range(len(template_slice)):
        if compare_slice[i] != template_slice[i]:
            mismatchIndex.append(i+1)
            mismatchCount += 1
  
    print ("-" *120)
    print ("ลำดับเบส DNA Template : {}" .format(template_slice))
    print ("ลำดับเบส DNA Compare : {}" .format(compare_slice))
    print ("ความยาวของลำดับเบส : {}" .format(len(template_slice)))
    print ("จำนวน DNA Mismatch : {} ({} %)" .format(mismatchCount, round(mismatchCount / len(template_slice) * 100, 2)))
    print ("ลำดับเบสที่เกิด DNA Mismatch : {}" .format(mismatchIndex))

baseMismatch()