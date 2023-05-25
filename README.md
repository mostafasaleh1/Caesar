# Caesar

##	What is Caesar cipher encryption method? 
Is one of the simplest and most widely known encryption techniques.

##	How does Caesar cipher method work? 
The encryption is done by representing each letter is with another letter located a little further in the alphabet, the difference between the represented letter and the representing letter is determined by a key, the key is simply how much letters we will skip until we reach the representing letter, for example:

Table 1. Letters
Plain	A	B	C	D	E	F	G	H	I	J	K	L	M	N	O		P	Q	R	S	T	U	V	W	X	Y	Z
Cipher	X	Y	Z	A	B	C	D	E	F	G	H	I	J	K	L		M	N	O	P	Q	R	S	T	U	V	W
End of Table 1. Letters


In the above table, each letter is represented by the subsequent letter in 23 orders, and 23 is the key or the shift. 

For example: 
Plaintext:  THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
Cipher text: QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD
Key = 23

###About the programme:
The programme is written in C#, Visual Studio 2019, windows forms application.
