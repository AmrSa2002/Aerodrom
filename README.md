# Grupa6-Aerodrom
Tema: Aviokompanija

Članovi tima: 

- Lejla Hodžić
- Nisveta Gafić

## Opis teme : 
Aplikacija olakšava planiranje i zakazivanje putovanja za korisnike. Omogućava putnicima da rezervišu kartu online, nudi uvid u raspoloživost karata i njihove cijene. Aplikacija aviokompaniji omogućava da ima uvid u to gdje korisnici putuju i u kojem broju, pa da prema tim podacima kreira svoju ponudu.

## Funkcionalnosti:

### Putnici: 
* mogućnost rezervacije leta
* mogućnost otkazivanja rezervacije
* mogućnost plaćanja karticom ili gotovinom
* mogućnost plaćanja na rate
* rezervacija se ne može otkazati 48h prije leta
* ostavljanje recenzije
* prikaz spiska svih letova u ponudi
* izbor sjedišta u avionu

###	Aviokompanija:
* mogućnost dodavanja novog leta
* mogućnost ukidanja postojećeg leta
* promjena cijene leta
* promjena vremena leta
* uvid u spisak putnika 
* uvid u spisak svih letova
* uvid u statistiku (koji su letovi najpopularniji)

### Akteri:
* Putnici: osobe koje rezervišu karte
* Radnici u aviokompaniji: osobe koje izdaju karte
* Administrator: osoba koja ima pravo da dodaje nove destinacije, mijenja cijene ili ukida postojeće destinacije

### Nefunkcionalni zahtjevi:
* Pouzdanost 

Aplikacija mora biti pouzdana, postoje ograničenja za rezervaciju karata (putnik ne može rezervirati kartu ako nema dovoljno novca na računu ili ako su sve karte već rezervisane). Ukoliko dođe do otkazivanja neke rezervacije 48h prije leta ta karta se svejedno mora platiti.

* Prijateljski interfejs i komunikacija sa sistemom

Putnici trebaju imati intuitivnu komunikaciju sa sistemom i moraju dobijati povratne informacije od sistema o svojim akcijama (dobijanje e-maila o potvrdi rezervacije). Sistem putniku prilikom pregleda destinacija treba da ponudi i letove koji uskoro idu, a u avionu ima još slobodnih mjesta.

* Sigurnost podataka

Podaci korisnika smiju biti dostupni samo administratoru (mora biti zaštićen broj kreditne kartice).

