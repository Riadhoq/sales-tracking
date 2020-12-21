import { Box } from "@chakra-ui/react";

export default function Sale({ data }) {
  return (
    <Box flex="200px" borderWidth="1px" borderRadius="lg" overflow="hidden">
      <Box p="6">
        <Box
          mt="1"
          fontWeight="semibold"
          as="h4"
          lineHeight="tight"
          isTruncated
        >
          {data.product.name}
        </Box>

        <Box>{"$" + data.product.salePrice.toFixed(2)}</Box>

        <Box color="gray.500" fontSize="sm">
          Bought by {data.customer.firstName}&nbsp;{data.customer.lastName}
        </Box>
        <Box color="gray.500" fontSize="sm">
          Sold by {data.salesperson.firstName}&nbsp;{data.salesperson.lastName}
        </Box>
      </Box>
    </Box>
  );
}
