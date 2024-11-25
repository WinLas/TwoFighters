# README

* ⚠️ **WIP**  
* ✅ **GREEN**  
* 🧠 **In Discovery**  
* ❌ **RED**  
* 📝 **TBD**  

---
US: MVP
The game in its initial MVP must showcase 2 BOTS fighting until one fighter is dead.

---
UAT: Happy scenario
IN:  
declare_winner(Fighter("Lew", 10, 2), Fighter("Harry", 5, 4), "Lew") => "Lew"
Expected OUTPUT:  
Lew attacks Harry; Harry now has 3 health.
Harry attacks Lew; Lew now has 6 health.
Lew attacks Harry; Harry now has 1 health.
Harry attacks Lew; Lew now has 2 health.
Lew attacks Harry: Harry now has -1 health and is dead. Lew wins.

---- 
UAT slice&Dice
1. Should have a fighter on a corner -> Fighter A
2. Fighter A should have a name -> "Red"
3. Fighter A should be healthy to fight -> health > 0
4. Fighter A should be able to strike the opponent (damage per attack = dpa) -> dpa > 0
5. Fighter A should be able to take damage -> health can be lowered

1. Should have a second fighter on the opposite corner -> Fighter B
2. Fighter B should have a name -> "Blue"
3. Fighter B should be healthy to fight -> health > 0
4. Fighter B should be able to strike the opponent (damage per attack = dpa) -> dpa > 0
5. Fighter B should be able to take damage -> health can be lowered

1. the fight should start when 2 opponents are in the "cage" -> Fighter A + B
2. somebody should start the fight -> Random(Fighter A || B)
3. who started should hit the opponent, and the opponent should intake the Foghter's damage per attack (dpa) ->
   A. Fighter B. health = Fighter B. health - Fighter A.dpa
   B. Fighter A. health = Fighter A. health - Fighter B.dpa

--> Rounds: the other will fight back IF? isn't death

--> continue until one is in the hospital/death/KO.