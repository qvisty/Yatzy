
//https://studie.smartlearning.dk/mod/page/view.php?id=609337
//Opgaven handler om terningspillet Yatzy, som I måske kender - I er også velkomne til at bruge tiden på noget andet, som I synes giver mere mening.

//Opgaven går ud på at simulere at de 5 terninger kastes. De 5 terningers øjne gemmes i variabler, f.eks. et array med 5 tilfældige tal mellem 1 og 6.

//Nu gælder det så om at finde ud af hvad denne kombination af de 5 terninger kan bruges til, og hvor mange point de giver og udskrive de mulige kombinationers point – point er antal øjne i kombinationen, dog giver yatzy altid 50 point uanset om det er fem 1’ere eller fem 6’ere.

//I yatzy er der følgende kombinationer: 1’ere, 2’ere, 3’ere, 4’ere, 5’ere og 6’er.
//Desuden er der et par, to par, tre ens, fire ens, fem ens (yatzy), fuldt hus(3 ens + et par), chancen(summen af alle terningerne), lille straight(1, 2, 3, 4, 5) og stor straight (2, 3, 4, 5, 6).

//F.eks.vil dette kast:  1 3 2 3 5
//kunne bruges til kombinationerne:
//1’ere: 1 point
//2’ere: 2 point
//3’ere: 6 point
//5’ere: 5 point
//et par: 6 point
//chancen: 14 point

//F.eks.vil dette kast:  1 4 1 4 4
//kunne bruges til kombinationerne:
//1’ere: 2 point
//4’ere: 12 point
//et par: 8 point(vælg altid højeste par)
//to par: 10 point
//tre ens: 12 point
//fuldt hus: 14 point
//chancen: 14 point