class Array:
    def __init__(self, arr=[]) -> None:
        self.arr = arr
        
    @property
    def array(self):
        return self.arr
    
    def filter(self, callback):
        i = 0
        while i < len(self.arr):
            valor = callback(self.arr[i])
            if valor == False:
                self.arr.pop(i)
            else:
                i += 1
    
    def find(self, callback):
        for x in self.arr:
            valor = callback(x)
            if valor == True:
                return x
            
        return None
    
    def map(self, callback):
        newArr = []
        for x in self.arr:
            if type(x) == int or type(x) == float:
                valor = callback(x)
            else:
                valor = None
            
            newArr.append(valor)
        
        return newArr
    
    def reduce(self, func, initial = None):
        iterator = iter(self.arr)
        
        if initial is None:
            try:
                initial = next(iterator)
            except:
                raise TypeError("reduce() of a empty array")
            
        accumulator = initial
        for item in iterator:
            accumulator = func(accumulator, item)
        
        return accumulator
    
    def sort(self, reverse=False):
        n = len(self.arr)
        for i in range(n):
            for j in range(0, n - i - 1):
                a = self.arr[j]
                b = self.arr[j+1]
                
                if(a > b and not reverse) or (a < b and reverse):
                    self.arr[j], self.arr[j+1] = self.arr[j + 1], self.arr[j]
    
""" arr1 = Array([1,2,3])
arr1.filter(lambda x: x > 2)
print(arr1.array)

arr2 = Array([1,2,3,4])
value = arr2.find(lambda x: x > 2)
print(value)
 """
""" arr3 = Array([1,2,'banana',4, 5.4])
newArr = arr3.map(lambda x: x * 2)
print(newArr) """

arr = Array([1, 2, 3, 4])

result_sum = arr.reduce(lambda acc, x: acc + x)
print("Sum:", result_sum) 

arr.sort()
print("Ascending:", arr.array)
    
arr.sort(reverse=True)
print("Descending:", arr.array) 