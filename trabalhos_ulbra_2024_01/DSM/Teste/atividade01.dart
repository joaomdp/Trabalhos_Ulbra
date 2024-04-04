void main() {
	double num1 = 2;
	double num2 = 10;
	String operacao = "/";

	double resultado = 0;

	switch (operacao) {
	  	case "+":
	    	resultado = num1 + num2;
	    break;
		case "-":
	    	resultado = num1 - num2;
	    break;
		case "*":
	    	resultado = num1 * num2;
	    break;
		case "/":
	    	resultado = num1 / num2;
	    break;
	} 

	print(resultado);
}