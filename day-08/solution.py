n = int(input())
pb = dict()
for i in range(n):
    line = input()
    line = line.split()
    pb[line[0]] = pb.get(line[0],line[1])

while True:
    try:
        q = input()
        if q in pb:
            print(str(q) + "=" + str(pb[q]))
        else:
            print("Not found")
    except:
        break