
TC = input().split(' ')


numberList=list(map(int,input().split(' ')))
mean = sum(numberList) / len(numberList)

tmp = 100
for i in range(len(numberList)):
    k=len(numberList)-i
    for j in range(1,k):
        if(numberList[j-1]<numberList[j]):
            tmp = numberList[j-1]
            numberList[j-1] = numberList[j]
            numberList[j] = tmp
print(numberList[int(TC[1])-1])

