var sentence = "У попа была собака"; 
var ignore = ["?", "!", ":", ";", ",", ".", " ",]; 
var arr = sentence.split(''); 
var letters = {}; 
var start = 0; 
var words = []; 
var result; 
// заполняем массив words словами разбивая строку по разделителю из separator 
arr.forEach(function (letter, i) { 
if (ignore.indexOf(letter) != -1) { 
words.push(sentence.substr(start, i - start)); 
start = ++i; 
} 
}); 
words.push(sentence.substr(start)); 
// ищем одинаковые буквы в словах и если есть добавляем в letters 
words.forEach(function (word) { 
word.split('').forEach(function (letter, i) { 
if (!letters[letter] && -1 != word.indexOf(letter, i + 1)) { 
letters[letter] = 1; 
} 
}); 
}); 
// проходим по всем буквам строки и удаляем те, что находятся в letters 
result = arr.filter(function (v) { 
return !letters[v]; 
}).join(''); 
console.log(result); 


alert(result);