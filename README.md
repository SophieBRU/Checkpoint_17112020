# Checkpoint_17112020

# Base de données
Un élève a un prénom, un nom de famille, appartient à une promotion et possède un ensemble de contrôles
Une promotion a un langage et plusieurs élèves peuvent lui appartenir
Un contrôle appartient à un élève et a une note
Insère deux promotions et dans chacune 5 élèves. Insère deux contrôles par élève.
Fournis un fichier SQL regroupant les 4 exercices précédents

# Data Abstraction Layer
Sur Visual Studio, crée un nouveau projet console .NET Core
Crée une classe statique DataAbstractionLayer
Implémente la méthode statique DataAbstractionLayer.Connect qui connecte ton programme à une base de données
Implémente la méthode statique DataAbstractionLayer.Disconnect qui déconnecte ton programme de la base de données
Crée une classe Student qui représente une entité en base de données
Implémente la méthode DataAbstractionLayer.SelectAllStudents qui retourne une collection d'objets de type Student contenant tous les étudiants en base de données
Ecris la méthode DataAbstractionLayer.SelectStudentByLastname qui retourne un étudiant en fonction de son nom de famille

# Jointures & Agrégats
Dans SSMS, écrit une requête qui récupère la moyenne des notes de chaque élève
Modifie la méthode DataAbstractionLayer.SelectAllStudents pour qu'elle affecte une propriété Average aux entités de type Student qu'elle retourne.
La propriété Student.Average contient la moyenne de toutes les notes d'un élève.

# Bonus
Crée une nouvelle branche à partir de ta branche principale (master ou main)
Dans cette nouvelle branche, refactorise tout ce que tu peux en utilisant EntityFrameworkCore
Pas grave si c'est pas fini, pousse ta branche on regardera ensemble par la suite
