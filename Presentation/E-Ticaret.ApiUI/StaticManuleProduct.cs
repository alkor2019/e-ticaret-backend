using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Domain.Entities;

namespace E_Ticaret.ApiUI
{
    public static class StaticManuleProduct
    {
        public static List<Product> AllStaticProducts()
        {
            List<Product> data = new();
            data.AddRange(new List<Product> (){
				  
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 4.53,
						UnitsInStock = 40
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 9.67,
						UnitsInStock = 98
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 20.09,
						UnitsInStock = 195
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 7.80,
						UnitsInStock = 124
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 13.44,
						UnitsInStock = 24
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 31.77,
						UnitsInStock = 108
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 44.15,
						UnitsInStock = 38
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 27.95,
						UnitsInStock = 103
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 44.70,
						UnitsInStock = 186
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 55.29,
						UnitsInStock = 158
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 12.23,
						UnitsInStock = 82
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 21.06,
						UnitsInStock = 127
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 11.24,
						UnitsInStock = 172
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 6.05,
						UnitsInStock = 141
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 9.84,
						UnitsInStock = 105
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 9.10,
						UnitsInStock = 132
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 58.27,
						UnitsInStock = 128
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 3.18,
						UnitsInStock = 193
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 44.58,
						UnitsInStock = 46
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 11.02,
						UnitsInStock = 97
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 30.00,
						UnitsInStock = 123
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 11.27,
						UnitsInStock = 143
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 3.34,
						UnitsInStock = 78
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 29.68,
						UnitsInStock = 70
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 12.28,
						UnitsInStock = 182
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 11.64,
						UnitsInStock = 172
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 63.55,
						UnitsInStock = 52
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 2.34,
						UnitsInStock = 83
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 24.03,
						UnitsInStock = 159
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 14.35,
						UnitsInStock = 195
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 30.81,
						UnitsInStock = 153
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 26.48,
						UnitsInStock = 192
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 64.75,
						UnitsInStock = 167
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 32.79,
						UnitsInStock = 76
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 11.51,
						UnitsInStock = 27
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 10.46,
						UnitsInStock = 59
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 29.84,
						UnitsInStock = 14
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 12.66,
						UnitsInStock = 12
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 3.46,
						UnitsInStock = 43
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 5.32,
						UnitsInStock = 191
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 41.30,
						UnitsInStock = 42
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 2.62,
						UnitsInStock = 190
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 27.75,
						UnitsInStock = 187
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 14.91,
						UnitsInStock = 58
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 24.85,
						UnitsInStock = 196
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 30.70,
						UnitsInStock = 50
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 28.66,
						UnitsInStock = 36
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 40.05,
						UnitsInStock = 162
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 18.89,
						UnitsInStock = 64
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 13.61,
						UnitsInStock = 121
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 31.53,
						UnitsInStock = 158
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 11.21,
						UnitsInStock = 166
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 5.48,
						UnitsInStock = 19
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 10.16,
						UnitsInStock = 41
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 16.58,
						UnitsInStock = 168
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 52.09,
						UnitsInStock = 200
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 12.36,
						UnitsInStock = 17
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 10.23,
						UnitsInStock = 63
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 36.96,
						UnitsInStock = 195
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 42.34,
						UnitsInStock = 23
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 10.96,
						UnitsInStock = 89
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 13.14,
						UnitsInStock = 63
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 48.51,
						UnitsInStock = 185
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 14.45,
						UnitsInStock = 114
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 13.77,
						UnitsInStock = 114
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 31.41,
						UnitsInStock = 119
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 6.48,
						UnitsInStock = 145
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 27.78,
						UnitsInStock = 79
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 43.38,
						UnitsInStock = 190
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 7.42,
						UnitsInStock = 131
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 29.47,
						UnitsInStock = 160
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 7.95,
						UnitsInStock = 76
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 10.74,
						UnitsInStock = 168
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 12.61,
						UnitsInStock = 164
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 21.36,
						UnitsInStock = 75
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 23.93,
						UnitsInStock = 63
					},
					new Product(){
						Name = "salads",
						CategoryId = 4,
						Price = 1.02,
						UnitsInStock = 91
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 31.44,
						UnitsInStock = 154
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 12.22,
						UnitsInStock = 186
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 7.35,
						UnitsInStock = 161
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 25.91,
						UnitsInStock = 118
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 24.44,
						UnitsInStock = 12
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 20.50,
						UnitsInStock = 74
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 3.03,
						UnitsInStock = 127
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 15.21,
						UnitsInStock = 45
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 12.77,
						UnitsInStock = 86
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 15.04,
						UnitsInStock = 94
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 19.31,
						UnitsInStock = 200
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 5.49,
						UnitsInStock = 142
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 5.45,
						UnitsInStock = 151
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 80.87,
						UnitsInStock = 14
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 19.48,
						UnitsInStock = 67
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 7.80,
						UnitsInStock = 102
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 42.61,
						UnitsInStock = 47
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 46.53,
						UnitsInStock = 155
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 77.71,
						UnitsInStock = 88
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 52.03,
						UnitsInStock = 177
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 9.70,
						UnitsInStock = 139
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 26.57,
						UnitsInStock = 78
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 52.03,
						UnitsInStock = 71
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 21.16,
						UnitsInStock = 24
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 21.42,
						UnitsInStock = 88
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 16.10,
						UnitsInStock = 80
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 19.16,
						UnitsInStock = 94
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 10.62,
						UnitsInStock = 65
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 2.40,
						UnitsInStock = 113
					},
					new Product(){
						Name = "salads",
						CategoryId = 4,
						Price = 24.48,
						UnitsInStock = 62
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 12.64,
						UnitsInStock = 17
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 36.94,
						UnitsInStock = 112
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 18.17,
						UnitsInStock = 156
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 53.80,
						UnitsInStock = 86
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 7.54,
						UnitsInStock = 40
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 19.28,
						UnitsInStock = 140
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 41.37,
						UnitsInStock = 83
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 50.38,
						UnitsInStock = 194
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 1.52,
						UnitsInStock = 197
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 38.10,
						UnitsInStock = 130
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 43.57,
						UnitsInStock = 175
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 0.39,
						UnitsInStock = 157
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 23.17,
						UnitsInStock = 195
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 19.24,
						UnitsInStock = 155
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 1.78,
						UnitsInStock = 130
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 29.77,
						UnitsInStock = 69
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 1.45,
						UnitsInStock = 194
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 19.22,
						UnitsInStock = 7
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 20.25,
						UnitsInStock = 70
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 9.38,
						UnitsInStock = 155
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 25.45,
						UnitsInStock = 110
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 52.19,
						UnitsInStock = 193
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 20.88,
						UnitsInStock = 106
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 8.44,
						UnitsInStock = 193
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 16.73,
						UnitsInStock = 77
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 29.06,
						UnitsInStock = 187
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 16.29,
						UnitsInStock = 125
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 18.57,
						UnitsInStock = 25
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 18.71,
						UnitsInStock = 179
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 7.25,
						UnitsInStock = 15
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 13.70,
						UnitsInStock = 33
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 1.78,
						UnitsInStock = 67
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 48.70,
						UnitsInStock = 57
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 6.60,
						UnitsInStock = 144
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 36.50,
						UnitsInStock = 154
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 32.27,
						UnitsInStock = 80
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 44.64,
						UnitsInStock = 116
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 47.95,
						UnitsInStock = 106
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 22.41,
						UnitsInStock = 116
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 27.53,
						UnitsInStock = 75
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 56.16,
						UnitsInStock = 119
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 10.45,
						UnitsInStock = 58
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 36.13,
						UnitsInStock = 30
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 30.65,
						UnitsInStock = 43
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 23.75,
						UnitsInStock = 159
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 11.80,
						UnitsInStock = 174
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 6.77,
						UnitsInStock = 177
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 16.64,
						UnitsInStock = 67
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 31.88,
						UnitsInStock = 187
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 28.32,
						UnitsInStock = 83
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 0.55,
						UnitsInStock = 147
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 5.40,
						UnitsInStock = 190
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 23.22,
						UnitsInStock = 96
					},
					new Product(){
						Name = "cereals",
						CategoryId = 4,
						Price = 6.97,
						UnitsInStock = 123
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 53.99,
						UnitsInStock = 112
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 14.42,
						UnitsInStock = 129
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 16.05,
						UnitsInStock = 147
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 25.01,
						UnitsInStock = 86
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 19.45,
						UnitsInStock = 137
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 36.46,
						UnitsInStock = 6
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 9.04,
						UnitsInStock = 68
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 31.05,
						UnitsInStock = 109
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 1.67,
						UnitsInStock = 190
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 34.46,
						UnitsInStock = 100
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 23.72,
						UnitsInStock = 167
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 23.51,
						UnitsInStock = 46
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 13.46,
						UnitsInStock = 73
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 9.91,
						UnitsInStock = 124
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 27.39,
						UnitsInStock = 84
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 14.19,
						UnitsInStock = 37
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 19.31,
						UnitsInStock = 154
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 19.13,
						UnitsInStock = 115
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 49.35,
						UnitsInStock = 46
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 21.58,
						UnitsInStock = 35
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 0.42,
						UnitsInStock = 42
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 4.06,
						UnitsInStock = 152
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 2.40,
						UnitsInStock = 127
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 19.66,
						UnitsInStock = 141
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 12.04,
						UnitsInStock = 112
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 47.23,
						UnitsInStock = 192
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 19.80,
						UnitsInStock = 102
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 41.79,
						UnitsInStock = 12
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 34.10,
						UnitsInStock = 189
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 8.19,
						UnitsInStock = 101
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 21.74,
						UnitsInStock = 155
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 5.78,
						UnitsInStock = 45
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 29.93,
						UnitsInStock = 12
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 6.37,
						UnitsInStock = 136
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 50.75,
						UnitsInStock = 156
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 6.62,
						UnitsInStock = 150
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 15.25,
						UnitsInStock = 64
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 6.68,
						UnitsInStock = 185
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 10.62,
						UnitsInStock = 135
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 35.52,
						UnitsInStock = 27
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 8.24,
						UnitsInStock = 170
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 32.47,
						UnitsInStock = 6
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 22.07,
						UnitsInStock = 184
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 37.99,
						UnitsInStock = 108
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 17.70,
						UnitsInStock = 187
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 33.14,
						UnitsInStock = 37
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 68.67,
						UnitsInStock = 5
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 8.18,
						UnitsInStock = 166
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 70.70,
						UnitsInStock = 157
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 0.67,
						UnitsInStock = 105
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 10.94,
						UnitsInStock = 72
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 31.70,
						UnitsInStock = 77
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 9.01,
						UnitsInStock = 194
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 12.20,
						UnitsInStock = 186
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 9.23,
						UnitsInStock = 90
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 6.42,
						UnitsInStock = 193
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 1.60,
						UnitsInStock = 113
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 36.45,
						UnitsInStock = 16
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 10.54,
						UnitsInStock = 92
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 28.43,
						UnitsInStock = 35
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 9.32,
						UnitsInStock = 89
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 42.32,
						UnitsInStock = 178
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 2.88,
						UnitsInStock = 36
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 11.33,
						UnitsInStock = 112
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 45.89,
						UnitsInStock = 20
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 0.99,
						UnitsInStock = 189
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 14.22,
						UnitsInStock = 84
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 17.49,
						UnitsInStock = 51
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 19.65,
						UnitsInStock = 80
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 68.98,
						UnitsInStock = 27
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 6.65,
						UnitsInStock = 138
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 15.86,
						UnitsInStock = 121
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 29.91,
						UnitsInStock = 42
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 39.16,
						UnitsInStock = 142
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 9.37,
						UnitsInStock = 34
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 55.78,
						UnitsInStock = 122
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 15.49,
						UnitsInStock = 143
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 11.58,
						UnitsInStock = 84
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 9.53,
						UnitsInStock = 163
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 17.65,
						UnitsInStock = 142
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 12.88,
						UnitsInStock = 187
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 21.90,
						UnitsInStock = 15
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 3.68,
						UnitsInStock = 119
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 3.69,
						UnitsInStock = 176
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 55.96,
						UnitsInStock = 52
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 4.48,
						UnitsInStock = 92
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 16.73,
						UnitsInStock = 92
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 66.92,
						UnitsInStock = 58
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 80.42,
						UnitsInStock = 20
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 23.24,
						UnitsInStock = 139
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 7.27,
						UnitsInStock = 95
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 7.11,
						UnitsInStock = 164
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 2.01,
						UnitsInStock = 193
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 21.68,
						UnitsInStock = 173
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 4.33,
						UnitsInStock = 192
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 32.46,
						UnitsInStock = 51
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 29.42,
						UnitsInStock = 149
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 14.33,
						UnitsInStock = 58
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 13.35,
						UnitsInStock = 163
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 1.32,
						UnitsInStock = 40
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 12.11,
						UnitsInStock = 8
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 1.60,
						UnitsInStock = 96
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 59.57,
						UnitsInStock = 6
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 35.49,
						UnitsInStock = 75
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 1.25,
						UnitsInStock = 87
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 5.18,
						UnitsInStock = 113
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 25.13,
						UnitsInStock = 17
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 30.68,
						UnitsInStock = 29
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 17.09,
						UnitsInStock = 104
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 34.84,
						UnitsInStock = 158
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 33.16,
						UnitsInStock = 163
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 25.55,
						UnitsInStock = 59
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 15.82,
						UnitsInStock = 28
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 26.07,
						UnitsInStock = 35
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 38.82,
						UnitsInStock = 6
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 5.58,
						UnitsInStock = 135
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 11.84,
						UnitsInStock = 190
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 61.51,
						UnitsInStock = 165
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 33.92,
						UnitsInStock = 38
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 19.01,
						UnitsInStock = 39
					},
					new Product(){
						Name = "salads",
						CategoryId = 4,
						Price = 21.12,
						UnitsInStock = 141
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 13.94,
						UnitsInStock = 130
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 10.66,
						UnitsInStock = 141
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 3.57,
						UnitsInStock = 138
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 2.41,
						UnitsInStock = 163
					},
					new Product(){
						Name = "salads",
						CategoryId = 4,
						Price = 6.54,
						UnitsInStock = 131
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 3.33,
						UnitsInStock = 174
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 32.27,
						UnitsInStock = 11
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 29.43,
						UnitsInStock = 117
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 12.62,
						UnitsInStock = 32
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 0.40,
						UnitsInStock = 32
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 11.73,
						UnitsInStock = 179
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 11.54,
						UnitsInStock = 120
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 10.94,
						UnitsInStock = 94
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 51.93,
						UnitsInStock = 121
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 3.59,
						UnitsInStock = 186
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 30.66,
						UnitsInStock = 134
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 25.99,
						UnitsInStock = 35
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 15.37,
						UnitsInStock = 11
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 23.91,
						UnitsInStock = 19
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 6.53,
						UnitsInStock = 54
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 8.68,
						UnitsInStock = 116
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 69.74,
						UnitsInStock = 112
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 38.91,
						UnitsInStock = 118
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 17.55,
						UnitsInStock = 74
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 4.47,
						UnitsInStock = 6
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 59.80,
						UnitsInStock = 98
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 24.46,
						UnitsInStock = 189
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 47.94,
						UnitsInStock = 63
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 0.67,
						UnitsInStock = 23
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 43.81,
						UnitsInStock = 142
					},
					new Product(){
						Name = "salads",
						CategoryId = 4,
						Price = 54.10,
						UnitsInStock = 94
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 10.80,
						UnitsInStock = 53
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 32.65,
						UnitsInStock = 91
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 2.69,
						UnitsInStock = 58
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 30.17,
						UnitsInStock = 88
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 21.56,
						UnitsInStock = 155
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 42.05,
						UnitsInStock = 128
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 3.77,
						UnitsInStock = 116
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 28.13,
						UnitsInStock = 8
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 34.42,
						UnitsInStock = 35
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 0.52,
						UnitsInStock = 11
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 35.24,
						UnitsInStock = 11
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 18.04,
						UnitsInStock = 43
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 5.21,
						UnitsInStock = 187
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 59.04,
						UnitsInStock = 126
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 7.79,
						UnitsInStock = 34
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 51.20,
						UnitsInStock = 126
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 14.22,
						UnitsInStock = 152
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 29.82,
						UnitsInStock = 159
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 16.45,
						UnitsInStock = 29
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 30.91,
						UnitsInStock = 129
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 34.05,
						UnitsInStock = 49
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 61.16,
						UnitsInStock = 158
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 16.41,
						UnitsInStock = 172
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 22.73,
						UnitsInStock = 160
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 22.15,
						UnitsInStock = 141
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 20.23,
						UnitsInStock = 137
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 0.17,
						UnitsInStock = 29
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 4.93,
						UnitsInStock = 161
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 39.95,
						UnitsInStock = 119
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 12.85,
						UnitsInStock = 173
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 7.31,
						UnitsInStock = 176
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 15.50,
						UnitsInStock = 53
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 18.08,
						UnitsInStock = 112
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 3.00,
						UnitsInStock = 197
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 16.80,
						UnitsInStock = 59
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 13.97,
						UnitsInStock = 75
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 15.61,
						UnitsInStock = 35
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 46.54,
						UnitsInStock = 65
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 3.14,
						UnitsInStock = 25
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 31.87,
						UnitsInStock = 148
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 2.51,
						UnitsInStock = 166
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 35.57,
						UnitsInStock = 13
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 33.66,
						UnitsInStock = 27
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 7.71,
						UnitsInStock = 24
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 36.41,
						UnitsInStock = 120
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 43.97,
						UnitsInStock = 77
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 7.07,
						UnitsInStock = 183
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 17.42,
						UnitsInStock = 66
					},
					new Product(){
						Name = "pasta",
						CategoryId = 4,
						Price = 28.48,
						UnitsInStock = 172
					},
					new Product(){
						Name = "desserts",
						CategoryId = 2,
						Price = 10.25,
						UnitsInStock = 116
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 4.97,
						UnitsInStock = 192
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 15.84,
						UnitsInStock = 184
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 26.76,
						UnitsInStock = 42
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 42.68,
						UnitsInStock = 102
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 47.92,
						UnitsInStock = 103
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 9.30,
						UnitsInStock = 85
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 25.00,
						UnitsInStock = 170
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 8.43,
						UnitsInStock = 133
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 31.60,
						UnitsInStock = 21
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 19.27,
						UnitsInStock = 176
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 55.35,
						UnitsInStock = 160
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 6.83,
						UnitsInStock = 39
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 5.55,
						UnitsInStock = 185
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 1.32,
						UnitsInStock = 140
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 11.93,
						UnitsInStock = 111
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 15.82,
						UnitsInStock = 64
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 5.86,
						UnitsInStock = 127
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 27.08,
						UnitsInStock = 50
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 38.02,
						UnitsInStock = 81
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 22.88,
						UnitsInStock = 92
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 1.41,
						UnitsInStock = 127
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 22.42,
						UnitsInStock = 67
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 22.27,
						UnitsInStock = 93
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 27.56,
						UnitsInStock = 58
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 44.52,
						UnitsInStock = 16
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 8.28,
						UnitsInStock = 195
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 9.76,
						UnitsInStock = 35
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 25.14,
						UnitsInStock = 67
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 12.04,
						UnitsInStock = 20
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 4,
						Price = 25.98,
						UnitsInStock = 191
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 18.88,
						UnitsInStock = 96
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 31.00,
						UnitsInStock = 57
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 22.23,
						UnitsInStock = 109
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 18.72,
						UnitsInStock = 58
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 7.39,
						UnitsInStock = 88
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 31.89,
						UnitsInStock = 47
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 11.56,
						UnitsInStock = 11
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 53.56,
						UnitsInStock = 120
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 29.01,
						UnitsInStock = 60
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 8.61,
						UnitsInStock = 198
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 0.55,
						UnitsInStock = 44
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 13.44,
						UnitsInStock = 89
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 8.13,
						UnitsInStock = 110
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 29.87,
						UnitsInStock = 181
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 59.88,
						UnitsInStock = 193
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 67.82,
						UnitsInStock = 115
					},
					new Product(){
						Name = "stews",
						CategoryId = 2,
						Price = 9.07,
						UnitsInStock = 196
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 25.31,
						UnitsInStock = 96
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 14.99,
						UnitsInStock = 178
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 3.51,
						UnitsInStock = 170
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 5.02,
						UnitsInStock = 13
					},
					new Product(){
						Name = "stews",
						CategoryId = 1,
						Price = 8.85,
						UnitsInStock = 142
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 7.60,
						UnitsInStock = 32
					},
					new Product(){
						Name = "desserts",
						CategoryId = 3,
						Price = 8.32,
						UnitsInStock = 156
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 16.27,
						UnitsInStock = 7
					},
					new Product(){
						Name = "cereals",
						CategoryId = 1,
						Price = 14.15,
						UnitsInStock = 119
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 20.77,
						UnitsInStock = 10
					},
					new Product(){
						Name = "desserts",
						CategoryId = 1,
						Price = 5.45,
						UnitsInStock = 193
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 19.68,
						UnitsInStock = 144
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 11.56,
						UnitsInStock = 100
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 62.27,
						UnitsInStock = 60
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 3.94,
						UnitsInStock = 100
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 11.56,
						UnitsInStock = 100
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 21.00,
						UnitsInStock = 173
					},
					new Product(){
						Name = "salads",
						CategoryId = 2,
						Price = 46.90,
						UnitsInStock = 174
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 27.43,
						UnitsInStock = 80
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 39.08,
						UnitsInStock = 111
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 33.92,
						UnitsInStock = 182
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 28.64,
						UnitsInStock = 46
					},
					new Product(){
						Name = "pies",
						CategoryId = 4,
						Price = 35.85,
						UnitsInStock = 96
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 0.30,
						UnitsInStock = 197
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 25.04,
						UnitsInStock = 51
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 1,
						Price = 0.90,
						UnitsInStock = 106
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 4.45,
						UnitsInStock = 192
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 14.20,
						UnitsInStock = 87
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 3.24,
						UnitsInStock = 55
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 28.41,
						UnitsInStock = 41
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 38.61,
						UnitsInStock = 179
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 2,
						Price = 5.90,
						UnitsInStock = 38
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 5.98,
						UnitsInStock = 133
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 21.21,
						UnitsInStock = 103
					},
					new Product(){
						Name = "seafood",
						CategoryId = 4,
						Price = 6.75,
						UnitsInStock = 115
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 8.41,
						UnitsInStock = 146
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 13.48,
						UnitsInStock = 123
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 2.42,
						UnitsInStock = 18
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 12.92,
						UnitsInStock = 181
					},
					new Product(){
						Name = "noodles",
						CategoryId = 4,
						Price = 44.95,
						UnitsInStock = 181
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 3.77,
						UnitsInStock = 164
					},
					new Product(){
						Name = "salads",
						CategoryId = 3,
						Price = 20.20,
						UnitsInStock = 71
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 58.05,
						UnitsInStock = 125
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 21.83,
						UnitsInStock = 187
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 32.83,
						UnitsInStock = 194
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 3.35,
						UnitsInStock = 151
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 11.80,
						UnitsInStock = 132
					},
					new Product(){
						Name = "soups",
						CategoryId = 1,
						Price = 17.35,
						UnitsInStock = 110
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 12.47,
						UnitsInStock = 181
					},
					new Product(){
						Name = "stews",
						CategoryId = 3,
						Price = 34.21,
						UnitsInStock = 107
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 36.93,
						UnitsInStock = 34
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 34.16,
						UnitsInStock = 195
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 25.95,
						UnitsInStock = 190
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 11.95,
						UnitsInStock = 68
					},
					new Product(){
						Name = "cereals",
						CategoryId = 2,
						Price = 28.79,
						UnitsInStock = 154
					},
					new Product(){
						Name = "salads",
						CategoryId = 1,
						Price = 34.90,
						UnitsInStock = 11
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 11.93,
						UnitsInStock = 34
					},
					new Product(){
						Name = "cereals",
						CategoryId = 3,
						Price = 17.33,
						UnitsInStock = 193
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 6.91,
						UnitsInStock = 176
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 30.47,
						UnitsInStock = 57
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 19.83,
						UnitsInStock = 76
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 6.37,
						UnitsInStock = 51
					},
					new Product(){
						Name = "stews",
						CategoryId = 4,
						Price = 10.32,
						UnitsInStock = 67
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 16.35,
						UnitsInStock = 184
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 54.94,
						UnitsInStock = 39
					},
					new Product(){
						Name = "seafood",
						CategoryId = 3,
						Price = 44.81,
						UnitsInStock = 196
					},
					new Product(){
						Name = "seafood",
						CategoryId = 1,
						Price = 18.05,
						UnitsInStock = 87
					},
					new Product(){
						Name = "pies",
						CategoryId = 2,
						Price = 28.79,
						UnitsInStock = 181
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 45.18,
						UnitsInStock = 148
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 16.14,
						UnitsInStock = 68
					},
					new Product(){
						Name = "soups",
						CategoryId = 2,
						Price = 34.92,
						UnitsInStock = 93
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 9.38,
						UnitsInStock = 141
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 41.14,
						UnitsInStock = 55
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 10.93,
						UnitsInStock = 109
					},
					new Product(){
						Name = "desserts",
						CategoryId = 4,
						Price = 22.19,
						UnitsInStock = 15
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 21.59,
						UnitsInStock = 77
					},
					new Product(){
						Name = "seafood",
						CategoryId = 2,
						Price = 28.69,
						UnitsInStock = 13
					},
					new Product(){
						Name = "pasta",
						CategoryId = 3,
						Price = 63.23,
						UnitsInStock = 192
					},
					new Product(){
						Name = "soups",
						CategoryId = 4,
						Price = 15.68,
						UnitsInStock = 41
					},
					new Product(){
						Name = "sandwiches",
						CategoryId = 3,
						Price = 28.51,
						UnitsInStock = 71
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 18.27,
						UnitsInStock = 23
					},
					new Product(){
						Name = "noodles",
						CategoryId = 3,
						Price = 13.40,
						UnitsInStock = 42
					},
					new Product(){
						Name = "noodles",
						CategoryId = 1,
						Price = 21.62,
						UnitsInStock = 195
					},
					new Product(){
						Name = "pasta",
						CategoryId = 2,
						Price = 45.07,
						UnitsInStock = 65
					},
					new Product(){
						Name = "pies",
						CategoryId = 1,
						Price = 34.22,
						UnitsInStock = 28
					},
					new Product(){
						Name = "noodles",
						CategoryId = 2,
						Price = 1.66,
						UnitsInStock = 21
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 35.87,
						UnitsInStock = 145
					},
					new Product(){
						Name = "pasta",
						CategoryId = 1,
						Price = 88.17,
						UnitsInStock = 182
					},
					new Product(){
						Name = "pies",
						CategoryId = 3,
						Price = 26.99,
						UnitsInStock = 44
					},
					new Product(){
						Name = "soups",
						CategoryId = 3,
						Price = 11.27,
						UnitsInStock = 118
					}

			}); return data;
        }
    }
}