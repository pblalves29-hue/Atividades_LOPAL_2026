using System;



    
    
        // Entrada de dados
        Console.WriteLine("=== Guilda dos Aventureiros ===");

        Console.Write("Nome do Herói: ");
        string nome = Console.ReadLine()!;

        Console.Write("Classe do Herói (Mago, Clérigo, Guerreiro, Druida, Anão, Elfo ou Troll): ");
        string classe = Console.ReadLine()!;

        Console.Write("Nível: ");
        int nivel;
        int.TryParse(Console.ReadLine(), out nivel);

        Console.Write("Pontos de Vida (HP): ");
        double hp;
        double.TryParse(Console.ReadLine(), out hp);

        Console.Write("Pontos de Mana: ");
        int mana;
        int.TryParse(Console.ReadLine(), out mana);

        Console.Write("Ouro na mochila: ");
        double ouro;
        double.TryParse(Console.ReadLine(), out ouro);

        Console.WriteLine("\n=== Avaliação da Guilda ===");

        // Regra da Raça Inimiga
        if (classe != "Troll" && !(nivel < 5))
        {
            Console.WriteLine("Herói aceito na guilda!");
        }
        else
        {
            Console.WriteLine("Troll detectado ou nível muito baixo! Expulso da guilda!");
            return;
        }

        // Cálculo do poder base
        double poderBase = (nivel * 10) + (hp / 2) - 5;
        Console.WriteLine($"Poder Base do herói: {poderBase}");

        // Regra do dano crítico
        if (poderBase % 2 == 0)
        {
            Console.WriteLine("⚔️ Ataque Crítico desbloqueado!");
        }

        bool podeAtacar = false;

        // Regra da magia
        if (classe == "Mago" || classe == "Druida" || classe == "Clérigo")
        {
            if (mana >= 30 && nivel <= 100)
            {
                Console.WriteLine("✨ O herói usa magia contra o dragão!");
                podeAtacar = true;
            }
            else
            {
                Console.WriteLine("O cajado falhou! Mana insuficiente.");
            }
        }

        // Regra do ataque físico
        else if (classe == "Guerreiro" || classe == "Anão" || classe == "Elfo")
        {
            if (hp > 20 && poderBase > 50)
            {
                Console.WriteLine("🛡️ Ataque físico poderoso contra o dragão!");
                podeAtacar = true;
            }
            else
            {
                Console.WriteLine("O herói é fraco demais para atacar.");
            }
        }

        // Caso não consiga atacar
        if (!podeAtacar)
        {
            Console.WriteLine("\nO herói não consegue lutar... tentando subornar o dragão!");

            if (ouro > 1000 || classe == "Anão")
            {
                Console.WriteLine("💰 O dragão aceita o suborno! O herói sobrevive!");
            }
            else
            {
                Console.WriteLine("🔥 O dragão recusa o suborno... virou churrasco!");
            }
        }

        Console.WriteLine("\n=== Fim da Avaliação ===");
    
