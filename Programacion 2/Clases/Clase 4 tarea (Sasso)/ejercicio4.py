dictionary = {}
print("Lets make an spanish to english translator, use the following format to add a word")
print("wordSpanish:wordEnglish,wordSpanish:wordEnglish ... etc")
txt = str(input().strip())
translation = str(txt).split(',')
for t in translation:
    word = t.split(':')
    dictionary.update({word[0]:word[1]})
print("Dictionary loaded, now write a sentence in spanish")
sentence = str(input())
word = sentence.split()
sentence = "";
for w in word:
    if w in dictionary:
        sentence += dictionary[w] + " "
    else:
        sentence += w
print(sentence)
        