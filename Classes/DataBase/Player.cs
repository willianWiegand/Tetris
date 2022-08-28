<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Tetris.Classes.DataBase {
  public class Player {
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome do jogador é obrigatório.")]
    [StringLength(50, ErrorMessage = "Nome do jogador deve ter no máximo 50 caracteres.")]
    public string Name { get; set; }
    public int Score { get; set; }

    #region "SQL"
    // Adiciona um novo jogador ao banco de dados na tabela Ranking
    public void AddPlayer() {
      try {
        var DB = new SQLServer();
        string SQL = ToInsert();

        DB.SQLCommand(SQL);
        DB.SQLClose();
      }
      catch (Exception ex) {
        throw new Exception($"Novo jogador não permitido: {ex.Message}");
      }
    }

    // Edita o Score do jogador atual quando finaliza a partida no Game Over
    public void EditScore() {
      try {
        string SQL = $"SELECT * FROM Ranking WHERE ID = '{Id}'";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count == 0) {
          DB.SQLClose();
          throw new Exception($"Jogador não existe: {Id}");
        }
        else {
          SQL = ToUpdate(Id);
          DB.SQLCommand(SQL);
          DB.SQLClose();
        }
      }
      catch (Exception ex) {

        throw new Exception("Erro ao alterar o jogador na base de dados: " + ex.Message);
      }
    }

    // Procura o último Id criado no banco de dados
    public int SearchLast() {
      try {
        string SQL = "SELECT * FROM Ranking WHERE Id = (SELECT MAX(Id) FROM Ranking)";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count == 0) {
          DB.SQLClose();
          throw new Exception($"Não existem jogadores!");
        }
        else {
          int id = Convert.ToInt32(DT.Rows[0]["Id"]);

          return id;
        }
      }
      catch (Exception ex) {

        throw new Exception($"Erro ao buscar o jogador na base de dados: {ex.Message}");
      }
    }

    // Lista o top 10 jogadores com pontuação decrescente
    public List<List<string>> SearchTop10() {
      List<List<string>> top10List = new List<List<string>>();

      try {
        string SQL = "SELECT TOP (10) * FROM Ranking ORDER BY Score DESC";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count > 0) {
          for (int i = 0; i < DT.Rows.Count; i++) {
            top10List.Add(new List<string> { DT.Rows[i]["Name"].ToString(), DT.Rows[i]["Score"].ToString() });
          }
        }
        else {
          throw new Exception("Base de dados está vazia! Não há jogadores!");
        }
      }
      catch (Exception ex) {

        throw new Exception($"Erro ao popular a lista: {ex.Message}");
      }

      return top10List;
    }

    // Método auxiliar de inserção de jogador no banco de dados
    public string ToInsert() {
      string SQL = @"INSERT INTO Ranking
                      (Id
                      ,Name
                      ,Score)
                      VALUES";

      SQL += $"('{Id}'" +
             $",'{Name}'" +
             $",'{Score}');";

      return SQL;
    }

    // Método auxiliar de atualização de jogador no banco de dados
    public string ToUpdate(int id) {
      string SQL = $"UPDATE Ranking" +
                   $" SET" +
                   $" Score = {Score}" +
                   $" WHERE Id = {id}";

      return SQL;
    }
    #endregion
  }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Tetris.Classes.DataBase {
  public class Player {
    public int Id { get; set; }
    [Required(ErrorMessage = "Nome do jogador é obrigatório.")]
    [StringLength(50, ErrorMessage = "Nome do jogador deve ter no máximo 50 caracteres.")]
    public string Name { get; set; }
    public int Score { get; set; }

    #region "SQL"
    // Adiciona um novo jogador ao banco de dados na tabela Ranking
    public void AddPlayer() {
      try {
        var DB = new SQLServer();
        string SQL = ToInsert();

        DB.SQLCommand(SQL);
        DB.SQLClose();
      }
      catch (Exception ex) {
        throw new Exception($"Novo jogador não permitido: {ex.Message}");
      }
    }

    // Edita o Score do jogador atual quando finaliza a partida no Game Over
    public void EditScore() {
      try {
        string SQL = $"SELECT * FROM Ranking WHERE ID = '{Id}'";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count == 0) {
          DB.SQLClose();
          throw new Exception($"Jogador não existe: {Id}");
        }
        else {
          SQL = ToUpdate(Id);
          DB.SQLCommand(SQL);
          DB.SQLClose();
        }
      }
      catch (Exception ex) {

        throw new Exception("Erro ao alterar o jogador na base de dados: " + ex.Message);
      }
    }

    // Procura o último Id criado no banco de dados
    public int SearchLast() {
      try {
        string SQL = "SELECT * FROM Ranking WHERE Id = (SELECT MAX(Id) FROM Ranking)";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count == 0) {
          DB.SQLClose();
          throw new Exception($"Não existem jogadores!");
        }
        else {
          int id = Convert.ToInt32(DT.Rows[0]["Id"]);

          return id;
        }
      }
      catch (Exception ex) {

        throw new Exception($"Erro ao buscar o jogador na base de dados: {ex.Message}");
      }
    }

    // Lista o top 10 jogadores com pontuação decrescente
    public List<List<string>> SearchTop10() {
      List<List<string>> top10List = new List<List<string>>();

      try {
        string SQL = "SELECT TOP (10) * FROM Ranking ORDER BY Score DESC";
        var DB = new SQLServer();
        var DT = DB.SQLQuery(SQL);

        if (DT.Rows.Count > 0) {
          for (int i = 0; i < DT.Rows.Count; i++) {
            top10List.Add(new List<string> { DT.Rows[i]["Name"].ToString(), DT.Rows[i]["Score"].ToString() });
          }
        }
        else {
          throw new Exception("Base de dados está vazia! Não há jogadores!");
        }
      }
      catch (Exception ex) {

        throw new Exception($"Erro ao popular a lista: {ex.Message}");
      }

      return top10List;
    }

    // Método auxiliar de inserção de jogador no banco de dados
    public string ToInsert() {
      string SQL = @"INSERT INTO Ranking
                      (Id
                      ,Name
                      ,Score)
                      VALUES";

      SQL += $"('{Id}'" +
             $",'{Name}'" +
             $",'{Score}');";

      return SQL;
    }

    // Método auxiliar de atualização de jogador no banco de dados
    public string ToUpdate(int id) {
      string SQL = $"UPDATE Ranking" +
                   $" SET" +
                   $" Score = {Score}" +
                   $" WHERE Id = {id}";

      return SQL;
    }
    #endregion
  }
}
>>>>>>> 18821ee0da2450dcfdfee11013fd72780ef4029f
