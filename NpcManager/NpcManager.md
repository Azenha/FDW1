https://learn.microsoft.com/pt-br/ef/core/modeling/relationships

# NpcManager

<!-- Tabela de NPCs -->
NpcDB
- PK Id `int`
- Nome `string`
- Descricao `string`
- Retrato `string`
- Origem (FK OrigemDB.Id)
- ExperienciaUm (FK ExperienciasDB.Id)
- ExperienciaDois (FK ExperienciasDB.Id)
- AutenticidadeUm (FK AutenticidadeDB.Id)
- AutenticidadeDois (FK AutenticidadeDB.Id)
- AutenticidadeTres (FK AutenticidadeDB.Id)

<!-- Origens ancentralidade cultura povo -->
OrigemDB
- PK Id `int`
- OrigemNome `string`
- OrigemDescricao `string`

<!-- Experiências de vida ocupações profissões classe -->
ExperienciasDB
- PK Id `int`
- ExperienciaNome `string`
- ExperienciaDescricao `string`

<!-- Traços de personalidade -->
AutenticidadesDB
- PK Id `int`
- AutenticidadeNome `string`
- AutenticidadeDescricao `string`