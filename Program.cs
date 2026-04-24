// Credito Rotativo
decimal valorTotal;
double percentualPagamentoMinimo, taxaJurosMensais;

decimal valorPagamentoMinimo;

Console.WriteLine("- Crédito Rotativo de Cartão de Crédito -\n");

Console.Write("Valor total da fatura (R$)...: ");
valorTotal = Convert.ToDecimal(Console.ReadLine());
Console.Write("Pagamento mínimo (%).........: ");
percentualPagamentoMinimo = Convert.ToDouble(Console.ReadLine()) / 100;
Console.Write("Taxa de juros mensais (%)....: \n");
taxaJurosMensais = Convert.ToDouble(Console.ReadLine()) / 100;

valorPagamentoMinimo = valorTotal * Convert.ToDecimal(percentualPagamentoMinimo);

Console.WriteLine($"\nPagamento mínimo..................: {valorPagamentoMinimo:C2}");

Console.WriteLine($"\nCaso seja pago o valor mínimo:");

Console.WriteLine($"Valor não pago....................: R$850,00");
Console.WriteLine($"Juros.............................: R$76,50");
Console.WriteLine($"IOF mensal........................: R$3,23");
Console.WriteLine($"IOF diário........................: R$2,09");
Console.WriteLine("");
Console.WriteLine($"Valor a pagar na próxima fatura...: R$931,82");
Console.WriteLine($"Custo do crédito rotativo.........: R$81,82");