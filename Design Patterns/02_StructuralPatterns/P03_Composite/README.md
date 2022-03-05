<h1>IT HierarchyApp</h1>
- Конзолното приложение е направено с цел имплементацията на Composite шаблона.

<h2>Описание</h2>
- Приложението има за цел да създава различни "рангове" от IT индустрията, като обектите, които имат по-висок "ранг" могат да отговарят за тези с по-нисък такъв.

<h2>Команди</h2>
<ul>
  <li> 
    CreateEmployee {EmployeeType} {FirstName} {LastName} - Създава служител.
    <ul>
      <li>Валидни employee типове: Developer, ITSupport, SecurityEnginer</li>
    </ul>  
  </li>
  <li> 
    CreateComposite {CompositeType} {FirstName} {LastName} - Създава composite.
    <ul>
      <li>Валидни composite типове: CTO, ITManager, ITSecurityManager, UserSupportManager, CyberSecurityLeader, InformationSecurityLeader</li>
    </ul> 
  </li>
  <li>AddEmployee {EmployeeFirstName} {CompositeFistName} - Добавя служител към екипа на определен composite.</li>
  <li>Display {CompositeFistName} - Показва цялата йерархия (кой на кого се подчинява).</li>
  <li>End - Прекратява програмата.</li>
</ul>

![Screenshot_1](https://user-images.githubusercontent.com/42496790/156658676-d380c8af-b6f2-4a19-a6bf-28eb785c5bcd.png)
