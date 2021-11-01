# Snowman

In this project, you will implement an interface for creating a Word Guessing
game. Then, using that library, you will implement a Guessing Game called
"Snowman" in Unity.

## Required Software

### .NET Core Test Explorer

This plugin allows you to quickly run C# Unit tests inside VS Code.

Get it from the VS Code Market Place:
[LINK](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)

### Markdown All in One

This plugin adds a bunch of nice features for writing Markdown.

Get it from the VS Code Market Place:
[LINK](https://marketplace.visualstudio.com/items?itemName=yzhang.markdown-all-in-one)

### Unity 2020.3.21f / Unity Hub

You should download an install Unity Hub and Unity 2020.3.21f as homework.

Coming soon: A video on completing the Unity installation

## Project Setup

### Fork Repository

For previous projects, you have signed up for the project using GitHub
classroom. This is not a normal work flow in the software development world. For
this project, you will be creating a forked repository. A forked repository
can be thought of a copy of the repository that contains the entire history
of the project that can later be merged back together.

To start out, 1 member from your group should fork the main repository.

![Fork](support/fork.png)

### Manage Access

After the fork has been created. The member who forked it should update the repository
so that each member of the group can access it.

1. Click Settings

![Settings](support/settings.png)

2. Rename your repository to be `snowman-username1-username2-username3`.
    * For example, Mx. Collard (jcollard) and Mr. DeVaughn-Brown (jd12) would rename their repository: `snowman-jcollard-jd12`

![Rename](support/rename.png)

3. Click Manage Access

![Manage Access](support/manageAccess.png)

4. Add People

![Add People](support/addPeople.png)

5. Add `jcollard` as well as your other group members. This will be their GitHub username.

6. Each member will receive an email with the invitation that they will need to accept.

### Clone Repository

Each person should now clone the repository to their computer. The name of the repository will
be prefixed with the username of the member who forked the repository. For example, Mx. Collard's fork
is called `jcollard/snowman-jcollard`.

![Clone](support/clone.png)

## Team work flow

For the first two milestones of this project, you and your group members will be working on the project
simultaneously. This can cause issues if you are modifying the same files at the same time. Git is a powerful
collaboration tool that attempts to make this easier.

### What is a Branch

A branch is a copy of the repository that allows for code to be edited in isolation, tested, and then either
combined or discarded depending on the results. 

### Disallow committing to main branch

Never commit to the main branch! The main branch should always contain the most recent, agreed upon project.
Committing directly to the main branch can cause major issues for your whole team. The most common iss
a conflict if two people are editing the same file at the same time.

You should **ALWAYS** work on a separate branch and later have your work merged via a pull requests when you're
ready to combine your work.

To help prevent this from happening, you can modify your repository to not accept pushes to the main branch:

1. Go to settings.
2. Select Branches

![Branches](support/branches.png)

3. Under Branch Protection Rules, click `Add Rule`

![Add Rule](support/addRule.png)

4. Type `main` into the `Branch pattern`
5. Select `Require a pull request before merging`

![Main Branch Rule](support/main.png)

6. Scroll to the bottom and select `Create`

![Create](support/create.png)

Congratulations! It is now not possible to push directly to the main branch.

### Creating a Branch

For this project, each group member will have their own branch.

Create a branch that matches your name. This is the branch where you will do all
of your own work.

1. Click on the source control icon in VS Code

![Source Control](support/sourcControl.png)

2. Select the `...` Menu > Branch > Create Branch ...

![Create Branch](support/createBranch.png)

3. Your branch name should be the first part of your email address. For example, `jcollard`
    * **Do not click Publish Changes yet!**

4. Add your name to the `Authors` Section of the WordGuesser/README.md document.
   * Note: Only add your individual name, do not add your entire teams name.

5. Commit your change.

6. Click Publish Changes. If you're asked, select `origin`.

![Publish Changes](support/publishChanges.png)

### Create a Pull Request

At this point, your changes are local to your branch. That is, your name is not visible on any other branch.

To combine work together using git, we perform a merge. Typically, this is done using a Pull Request. This is a feature
that GitHub provides. For now, we will create a Pull Request using GitHubs interface (note: you can also do this directly in VS Code).

1. Go to your group's project on GitHub.
2. Click the `Pull Requests` tab

![Pull Requests](support/PullRequests.png)

3. Click `New Pull Request`

![New Pull Request](support/newPR.png)

4. Make sure the target repo on the left is your project.

![Your Project](support/yourRepo.png)

5. Select that you want to merge to `main` from `your-branch`

6. Click `Create Pull Request`

![Create Pull Request](support/createPR.png)

7. Click Add Reviewer and add your group members to review your Pull Request
   
![Add Reviewer](support/addReviewer.png)

8. Click `Create Pull Request`

![Create PR2](support/createPullRequest.png)

You're now ready for your group members to review your work!

### Merge a Pull Request

Now, it is up to you to review your group members work and merge their work into
the main branch. After everyone has created a Pull Request:

1. Go to the Pull Requests tab
2. Open one of your group members Pull Requests
3. Click on `Files Changed`

![Files Changed](support/fileschanged.png)

This page shows all of the changes that the person made. You can add comments
directly on each line of the changes. For this change, you're simply going to 
add a simple review.

4. Add a Review by clicking `Review Changes`

![Review Changes](support/reviewChanges.png)

5. Add a message, "Looks good to me!" or "lgtm!" for short. Select `Approve`. Then click `Submit Review`

![lgmt](support/lgtm.png)

Your review is now added to the Pull Request. This also, by approving the pull request, the `Merge` button
is now green.   
   
6. Click `Merge Pull Request`. Then click `Confirm merge`
   * If someone else merged before you, you will now have a conflict. This happens when multiple people modify the same line of a file like we did when adding in our author names. We will show how to resolve this in the next section.
7. Do NOT click the `Delete Branch` button. For this project, you will continue to use your individual branches to make your changes.

### Resolving Conflicts

In the previous step, both group members modified the same file AND the same line. Normally, git is pretty good at
merging changes to the same file as long as they are not on the same section of code. In this case, git needs a little
help to resolve the conflict. The simplest way to resolve this is to merge the new main branch into your branch in VS Code.

1. Open your project in VS Code

First we need to get the latest version of the main branch.

2. Click the branch icon in the bottom left of VS Code

![Switch Branch](support/switchBranch.png)

3. When prompted, select `main`

4. Next to the `main` branch, you will see that it shows there are changes that need to be pulled (the number on the left). To `sync` your project, click this button.

![Sync](support/sync.png)

If prompted, click `Ok`. Your main branch is now synced!

5. Switch back to your branch by clicking on the branch icon again and selecting your branch.

6. Next, we will merge the changes from `main` to your branch. Go to the Source Control tab.

![Source Control](support/sourcControl.png)

7. Select the `...` menu > Branch > Merge Branch

![Merge Main](support/mergeMain.png)

8. When prompted select `main`

You should see a Merge conflict open. For this conflict, we want to accept both changes.

9. Select `Accept Both Changes`

![Accept Both](support/acceptBoth.png)

10. Save your file. Commit and Push

11. Return to your Pull Request and finish the merge.

### Merging Main into your Branch

Throughout your project, you should merge any changes from the main branch into your branch. This will keep it up
to date with your group members:

1. Open your project in VS Code

First we need to get the latest version of the main branch.

2. Click the branch icon in the bottom left of VS Code

![Switch Branch](support/switchBranch.png)

3. When prompted, select `main`

4. Next to the `main` branch, you will see that it shows there are changes that need to be pulled (the number on the left). To `sync` your project, click this button.

![Sync](support/sync.png)

If prompted, click `Ok`. Your main branch is now synced!

5. Switch back to your branch by clicking on the branch icon again and selecting your branch.

6. Next, we will merge the changes from `main` to your branch. Go to the Source Control tab.

![Source Control](support/sourcControl.png)

7. Select the `...` menu > Branch > Merge Branch

![Merge Main](support/mergeMain.png)

8. When prompted select `main`

9. If necessary, resolve any merge conflicts.

## Create a Feedback Pull Request

Create a pull request from your `main` branch to the `ChadwickCSP/main` branch.
Add Mx. Collard as a reviewer.

This is where you will receive feedback from Mx. Collard.

## Milestone 1

* E Period Due: Wednesday Nov. 3rd @ 11:59 PM 
* C Period Due: Thursday Nov. 4th @ 11:59 PM

Complete flowcharts and design document

## Milestone 2

* E Period Due: Monday Nov. 8th @ 11:59 PM 
* C Period Due: Tuesday Nov 9th @ 11:59 PM

Complete Word Game

## Milestone 3

* E Period Due: Wednesday Nov 10th @ 11:59 PM 
* C Period Due: Thursday Nov 11th @ 11:59 PM

Setting up Unity Coming Soon!

## Milestone 4

* E Period Due: Wednesday Nov 17th @ 11:59 PM 
* C Period Due: Thursday Nov 18th @ 11:59 PM

Complete the Snowman Game Coming Soon!

## Milestone 5

* E Period Due: Thursday Nov 18th
* C Period Due: Friday Nov 19th

Complete Written Response

Coming Soon!