function countExpressions() {
    let expression = "15+54/2-21.9*2.3= "
    let regex = / ?\d+(\.\d+)?|[\+,\-,\*,\/,\=]{1} /ig;
    let tempArr = expression.match(regex), numArr = [], mathArr = [];

    tempArr.forEach(function (element) {
        if(isNaN(+element)){
            mathArr.push(element);
        } else{
            numArr.push(+element);
        }
    });

    let result = numArr[0];
    let j = 0;

    for(let i = 1; i < numArr.length; i++){
        switch (mathArr[j]){
            case "-" : result -= numArr[i];
            break;
            case "+" : result += numArr[i];
            break;
            case "*" : result += numArr[i];
            break;
            case "/" : result /= numArr[i];
        }
        j++;
    }
    return result.toFixed(2);
}

alert(countExpressions());