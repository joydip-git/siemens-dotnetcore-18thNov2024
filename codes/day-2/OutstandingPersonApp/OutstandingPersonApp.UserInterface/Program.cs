using OutstandingPersonApp.Entities;
//using OutstandingPersonApp.UserInterface;

//static import
//using static OutstandingPersonApp.UserInterface.PersonUtility;

int count = GetRecordCount();
Person?[] people = new Person[count];
SavePersonInStorage(count, people);