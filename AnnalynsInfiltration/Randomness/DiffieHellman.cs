using System;
using System.Numerics;

public static class DiffieHellman
{
    //public static BigInteger PrivateKey(BigInteger primeP) => new Random().Next(2, (int)primeP - 1);


    ///*
    // Formula: g^a mod p  
    // donde g = primeG
    // donde p = primeP
    // donde privateKey = clave privada de cada uno.

    //ej: 6^5 mod 13 = 2. 
    //Porque: 6^5 = 7776.
    //mod significa el resto de hacer la division entre 7776 y 13. Es decir: 7776 % 13 = 2 -> El resto de hacer esta división es 2.
    // */
    //public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => new (Math.Pow((int)primeG, (int)privateKey) % (int)primeP); 

    //public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => new (Math.Pow((int)publicKey, (int)privateKey) % (int)primeP);


    //Otra forma mas facil de hacerlo:
    public static BigInteger PrivateKey(BigInteger primeP) => new Random().Next(2, (int)primeP - 1);

    public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey) => BigInteger.ModPow(primeG, privateKey, primeP);

    public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey) => BigInteger.ModPow(publicKey, privateKey, primeP);
}