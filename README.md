# Quantity System Framework and Calculator #
<https://github.com/timdetering/QuantitySystem>

## Project Description ##
Quantity System is an attempt to make a framework to support scientific calculations through units conversions and quantities predictions.

Based on Dimensional approach not Units approach.

The first to differentiate between Torque, and Work, Angle, and Solid Angle.
Live demo for the calculator can be found in http://quantitysystem.org

Project Blog http://quantitysystem.wordpress.com

## Requirements ##
 * Microsoft .net Framework 4.0 <http://www.microsoft.com/downloads/en/details.aspx?displaylang=en&FamilyID=0a391abd-25c1-4fc0-919f-b21f31ab88b7>

## Note ##
During porting the source code from CodePlex (SVN) to GitHub (Git), there was an error:

    $ git svn clone https://quantitysystem.svn.codeplex.com/svn
    ...
    $ r31852 = 136be6269406386f72328af19ff177686d426252 (refs/remotes/git-svn)
              M       QuantitySystemSolution/QuantitySystem.Runtime/RuntimeTypes/QsMatrixOperations.cs
              M       QuantitySystemSolution/QuantitySystem.Runtime/RuntimeTypes/QsMatrix.cs
              M       QuantitySystemSolution/QuantitySystem.Runtime/Runtime/QsVar.cs
      QuantitySystemSolution/QuantitySystem.Runtime/Runtime/QsNamespace.cs was not found in commit 136be6269406386f72328af19ff177686d426252 (r31852)

There was a problem with the source code import at revision 31852. To workaround the issue without spending too much time, I re-cloned the repository from the trouble commit forward:

    $ git svn clone -r31853:HEAD https://quantitysystem.svn.codeplex.com/svn

## References ##
 * Quantity System Framework - CodePlex <https://quantitysystem.codeplex.com>
 * How to git-svn clone the last n revisions from a Subversion repository? - Stack Overflow <http://stackoverflow.com/questions/747075/how-to-git-svn-clone-the-last-n-revisions-from-a-subversion-repository>

