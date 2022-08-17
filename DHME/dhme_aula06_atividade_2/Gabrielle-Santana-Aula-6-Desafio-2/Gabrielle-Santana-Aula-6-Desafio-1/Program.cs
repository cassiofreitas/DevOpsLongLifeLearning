Console.WriteLine("Quantos quilometros você percorreu?");

float quilometros = int.Parse(Console.ReadLine());

// conversão dos quilometros percorridos pelo veículo para milhas. 
float milhas = (float)(quilometros * 0.62137);

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu veículo percorreu um total de XXXXXX milhas.

Console.WriteLine($"Seu veículo percorreu um total de {milhas} milhas.");
