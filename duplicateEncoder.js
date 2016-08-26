function duplicateEncode(word){
    word = word.toLowerCase();

    var hashedIndex = buildHashFromWord(word);
    
    var result = '';

    for(var i = 0; i < word.length; i++){
        if(hashedIndex[word[i]] === 1){
            result += '(';
        } else {
            result += ')';
        }
    }

    return result;
}

function buildHashFromWord(word){
    var hash = {};
    for(var i = 0; i < word.length; i++){
        if(!hash[word[i]]){
            hash[word[i]] = 1;
        } else {
            hash[word[i]] = hash[word[i]] + 1;
        }
    }

    return hash;
}