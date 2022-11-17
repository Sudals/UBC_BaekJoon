s = input().upper()
unlist = list(set(s))
maxN = 0
res=[]
for i in unlist:
    cnt=s.count(i)
    res.append(cnt)
if res.count(max(res))>1:
   print('?')
else:
    maxN = res.index(max(res))
    print(unlist[maxN])
