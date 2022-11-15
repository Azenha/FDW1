https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/data-annotations?redirectedfrom=MSDN#Relationships

https://stackoverflow-com.translate.goog/questions/19864974/code-first-entity-framework-multiple-foreign-keys-for-the-same-table?_x_tr_sl=auto&_x_tr_tl=en&_x_tr_hl=pt-BR&_x_tr_pto=wapp

https://stackoverflow-com.translate.goog/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table?_x_tr_sl=auto&_x_tr_tl=en&_x_tr_hl=pt-BR&_x_tr_pto=wapp#5559300

https://entityframeworkcore.com/knowledge-base/22281078/two-foreign-keys-with-same-navigation-property-

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