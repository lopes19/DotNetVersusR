text_vector <- readLines("DoubleNumbers.txt")

number_vector = as.numeric(text_vector)

sd(number_vector)

var(number_vector)


cumulativeProfitability <- 0
for(num in number_vector)
{
	cumulativeProfitability <- (( (1+(cumulativeProfitability/100)) * (1+(num/100)) ) -1) *100
}
print(cumulativeProfitability)