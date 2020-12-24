import { Box, Flex } from "@chakra-ui/react";
import Link from "next/link";
import Salesperson from "../components/Salesperson";

export default function Salespeople({ data }) {
  return (
    <Flex px={10} py={10} maxW={800} mx="auto" gridGap="10px" wrap="wrap">
      <Link href="/salesperson/create">
        <Box
          d="inline-block"
          borderRadius="md"
          py="3"
          as="button"
          bgColor="green.100"
          w="100%"
        >
          Create a salesperson
        </Box>
      </Link>
      {data.map((salesperson) => (
        <Salesperson key={salesperson.salespersonId} data={salesperson} />
      ))}
    </Flex>
  );
}

Salespeople.getInitialProps = async (ctx) => {
  const res = await fetch(`${process.env.apiBaseUrl}/salespeople`);
  const data = await res.json();
  return { data };
};
