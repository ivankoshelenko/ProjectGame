INCLUDE globals.ink
VAR scriptEnding = 0
{pokemon_name == "":->setname | {pokemon_name}!}
===setname===
~pokemon_name = "ivan"
*[cont]
~scriptEnding =1
->END
=== already_chose ===
You already chose {pokemon_name}!

*[Good job!]
~ scriptEnding =1
->END