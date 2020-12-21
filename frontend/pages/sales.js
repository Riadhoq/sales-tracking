import { Box, Flex } from "@chakra-ui/react";
import Link from "next/link";
import Sale from "../components/Sale";

export default function Sales({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Link href="/create-sale">
        <Box
          d="inline-block"
          borderRadius="md"
          py="3"
          as="button"
          bgColor="green.100"
          w="100%"
        >
          Create a Sale
        </Box>
      </Link>
      {data.map((s) => (
        <Sale key={s.salesId} data={s} />
      ))}
    </Flex>
  );
}

Sales.getInitialProps = async (ctx) => {
  const res = await fetch(`${process.env.apiBaseUrl}/sales`);
  const data = await res.json();
  return { data };
};
