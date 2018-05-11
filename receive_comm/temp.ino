#include "temp.h"

#define Vcc 5.0
#define KR	5.0/1024.0	// costante per convertire la misura analogica in Volt

#define R2	9900		// da sostituire con un valore identico alla resistenza dell'NTC a 25°

// tabella dei vaori di resistenza da TMIN a TMAX
const float RT[] =
{
	31770,	//0	TMIN 
	24940, 	//5
	19680,   //10
	15620,  //15
	12470,	//20
	10000,	//25	
	8064,		//30
	6538,		//35
	5327,		//40
	4363,   //45  
	3592,   //50
	2972,   //55
	2472 ,  //60
	2066,   //65
	1735,   //70
	1465,   //75	
	1243,   //80
	1059,   //85
  908,    //90
  781,    //95
	674,		// 100 	TMAX


  
};



const int NPT = sizeof(RT) / sizeof(RT[0]);

// misura la temperatura
float GetTemp(void)
{
	float Vt = analogRead(PIN_T) * KR;	// tensione misurata in volt
	return ConvertToC(Vt);
}

// converte in °C
float ConvertToC(float Vt)
{
	int i;
	float rt = ( Vcc - Vt )* R2 / Vt;	
		
	if (rt >= RT[0])				// conversione in gradi
		return TMIN;

	for (i = 1; i < NPT; i++ )
		if ( RT[i] <= rt )
			break;

	if ( i == NPT )
		return TMAX;

	return  Vcc * ( rt - RT[i-1] ) / ( RT[i] - RT[i-1] ) + Vcc * (i-1);
	
}

