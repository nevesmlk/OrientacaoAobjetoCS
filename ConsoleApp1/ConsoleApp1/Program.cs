﻿

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Igor Neves";
//conta1.conta = "251336 - x";
//conta1.saldo = 105.98;
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agência Central";

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da agência: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "nevesmlk";
//conta2.conta = "2256987 - x";
//conta2.saldo = 203.98;
//conta2.numero_agencia = 26;
//conta2.nome_agencia = "Agência Central";

//Console.WriteLine("Saldo pré-transferência " + conta1.saldo);
//Console.WriteLine("Saldo pré-transferência " + conta2.saldo);
//bool  transferir = conta1.transferir(50, conta2);
//Console.WriteLine("Transferência realizada? " + transferir);
//Console.WriteLine("Saldo pós-transferência " + conta1.saldo);
//Console.WriteLine("Saldo pós-transferÊncia " + conta2.saldo);

//Console.WriteLine("Saldo pré-saque: " + conta1.saldo);
//bool saque = conta1.sacar(50);
//Console.WriteLine("Saque realizado? "+ saque);
//Console.WriteLine("Saldo pós-saque: " + conta1.saldo);
//conta1.Depositar(60);
//Console.WriteLine("Saldo pós-depósito: " + conta1.saldo);

using ByteBank;
using ByteBank.titular;

Cliente cliente = new Cliente();

cliente.nome = "Igor Neves";
cliente.cpf = "254938257 - 38";
cliente.profissao = "Tecnólogo";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;
conta3.conta = "25413698";
conta3.numero_agencia = 33;
conta3.nome_agencia = "Agencia Central";

Console.WriteLine(cliente.nome);
Console.WriteLine(conta3.titular.nome);







Console.ReadKey();

