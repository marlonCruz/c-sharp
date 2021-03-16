usando el  sistema ;
utilizando  System . Colecciones . Genérico ;

 listados de espacios de nombres
{
     programa de clase
    {
        static  void  Main ( cadena [] argumentos )
        {
            Lista < cadena > nombres  =  nueva  Lista < cadena > ();
            nombres . Agregar ( " Juan " );
            nombres . Agregar ( " Pedro " );
            nombres . Agregar ( " María " );

            foreach ( var  nombre  en  nombres )
            {
                Consola . WriteLine ( nombre );
            }

            Lista < int > numeros  =  nueva  Lista < int > ();
            numeros . Agregar ( 10 );
            numeros . Agregar ( 1 );
            numeros . Agregar ( 5 );

            foreach ( var  n  en  numeros )
            {
                Consola . WriteLine ( n );
            }

            Lista < alumno > alumnos  =  nueva  lista < alumno > ();
            Alumno  un  =  nuevo  alumno ( 1 , " Pedro " );
            Alumno  b  =  nuevo  alumno ( 2 , " Maria " );
            Alumno  c  =  nuevo  alumno ( 3 , " Juan " );

            alumnos . Agregue ( a );
            alumnos . Agregue ( b );
            alumnos . Agregar ( c );

            foreach ( var  alumno  en  alumnos )
            {
                Consola . WriteLine ( alumno . Id );
            }
        }
    }
}