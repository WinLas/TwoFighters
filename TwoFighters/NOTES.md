# Notes

* ⚠️ **WIP**  
* ✅ **GREEN**  
* 🧠 **In Discovery**  
* ❌ **RED**  
* 📝 **TBD**  

### Goal: 

1. Skapa fighter-klassen
2. Skapa fighten

### Time 🍅
### Notes:

Fighter-klassen
1. ~~Testa att en fighter har ett namn~~
2. ~~Testa att en fighter har hp~~
3. ~~Testa att en fighter har skadepoäng~~
4. ~~Testa att en fighters hp kan sänkas (ta skada)~~

Fighten
1. Testa att en fighter kan börja
   * båda har samma health och dör vid första slaget, den som startar vinner
   * out = vinnarens namn
2. Testa att en fighter kan skada en annan fighter
   * output skrivs till konsol, NSUB?
3. Testa att utse rätt vinnare
   * den som börjar vinner inte per automatik

Starter           |  Second fighter

| HP | DPA | Name  | HP | DPA | Name  | Winner |
|----|-----|-------|----|-----|-------|--------|
| 1  | 1   | Lew   | 1  | 1   | Harry | Lew    |  -> ~~starter kills on first hit~~ ✅
| 1  | 1   | Harry | 1  | 1   | Lew   | Harry  |  -> ~~starter kills on first hit~~ ✅
| 1  | 1   | Lew   | 2  | 1   | Harry | Harry  |  -> ~~first punch is not deadly, second is winner~~ ✅
| 2  | 1   | Lew   | 2  | 1   | Harry | Lew    |  -> Second punches are deadly
