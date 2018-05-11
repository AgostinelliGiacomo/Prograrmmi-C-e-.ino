
#define TMIN	0		// temperatura minima 
#define TMAX	100		// massima 
#define DT		5		// incremento in tabella

#define PIN_T	A0		// pin analogico di misura 

// prototoipi -----------------------------------------
// misura la temperatura
float GetTemp(void);

// converte in °C
float ConvertToC(float vt);
