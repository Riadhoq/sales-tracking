import { Box, Flex } from "@chakra-ui/react";
import Link from "next/link";

function Product({ data }) {
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
          {data.name}
        </Box>

        <Box>{"$" + data.salePrice.toFixed(2)}</Box>

        <Box d="flex" alignItems="center">
          <Box as="span" color="gray.600" fontSize="sm">
            {data.quantityOnHand} available
          </Box>
        </Box>
        <Box color="gray.500" fontSize="sm">
          by {data.manufacturer}
        </Box>
        <Flex mt="2">
          <Link href={`/product/${data.productId}`}>
            <Box
              borderRadius="sm"
              as="button"
              fontSize="sm"
              px="2"
              py="1"
              bgColor="blue.900"
              color="white"
            >
              Details
            </Box>
          </Link>
          <Link href={`/product/edit/${data.productId}`}>
            <Box
              borderRadius="sm"
              as="button"
              fontSize="sm"
              ml="2"
              px="2"
              py="1"
              bgColor="teal.700"
              color="white"
            >
              Edit
            </Box>
          </Link>
        </Flex>
      </Box>
    </Box>
  );
}

export default Product;
