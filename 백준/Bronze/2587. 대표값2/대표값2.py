
numberList=[]
for i in range(0, 5):
    numberList.append(int(input()))
    
mean = sum(numberList) / len(numberList)

tmp = 100
for i in range(len(numberList)):
    k=len(numberList)-i
    for j in range(1,k):
        if(numberList[j-1]>numberList[j]):
            tmp = numberList[j-1]
            numberList[j-1] = numberList[j]
            numberList[j] = tmp
        
print(int(mean),"\n"+str(numberList[2]))

