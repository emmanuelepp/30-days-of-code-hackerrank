
arr = []

for _ in range(6):
    arr.append(list(map(int, input().rstrip().split())))

#############################################################

maxi = -64

for i in range(0, 4):
    for j in range(0, 4):
        result = arr[i][j] + arr[i][j+1] + arr[i][j+2] + \
            arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2]
        if result > maxi:
            maxi = result

print(maxi)
