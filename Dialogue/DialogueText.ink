
INCLUDE globals.ink
VAR scriptEnding =0
{ pokemon_name == "": -> main | -> already_chose }

=== main ===
Which pokemon do you choose?
    + [Charmander]
        -> chosen("Charmander")
    + [Bulbasaur]
        -> chosen("Bulbasaur")
    + [Squirtle]
        -> chosen("Squirtle")
        
=== chosen(pokemon) ===
~ pokemon_name = pokemon
You chose {pokemon}!
*[End dialogue]
~ scriptEnding =1
-> END

=== already_chose ===
You already chose {pokemon_name}!

*[Good job!]
~ scriptEnding =1
->END