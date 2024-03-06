#wap for stone paper scissor

print("Enter any one option \n1:Stone\n2:Paper\n3:Scissor")
player1=input("Enter player 1's choice")
player2=input("Enter player 2's choice")
def game():
    if player1==player2:
        print("Tie -_-")
    elif player1=="Stone" and player2=="Paper":
        print("Player 1 wins!")
    elif player1=="Scissor" and player2=="Paper":
        print("Player 1 wins!")
    elif player1=="Paper" and player2=="Stone":
        print("Player 1 wins!")
    else:
        print("Player 2 wins!")
game()
