const array1 = [1, 4, 9, 16]

function map(arr, elemento) {
    const novaArray = []
    for (let i = 0; i < arr.length; i++) {
        const valor = elemento(arr[i])
        console.log(valor)
        novaArray.push(valor)
        


    }
    return novaArray

}

const resultado = map(array1, (arr) => arr * 2)
console.log(resultado)