

//Console.WriteLine(Role.systemUser.ToString("D"));     //Format Decimal --> 0

//Console.WriteLine((int)Role.systemUser);    //Explicit casting


using Enumeration;

int role = 1;
if (role == (int)Role.admin)
    Console.WriteLine("transfer to admin area");

if (role == (int)Role.contentUser)
    Console.WriteLine("transfer to content user area");

Console.ReadKey();